using System;
using System.Data; 
using System.Drawing; 
using System.Collections.Generic;   
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using DbConsoleService; 

namespace DbConsole
{
    public partial class MainForm : Form
    {
        Dictionary<string, IDbConsoleProvider> m_Providers;
        DbConsoleManager m_Manager;

        public MainForm()
        {
            InitializeComponent();
            LoadProviders();
            ShowProviders(); 
        }

        public void LoadProviders()
        {
            if (m_Providers == null)
                m_Providers = new Dictionary<string, IDbConsoleProvider>();
            else
                m_Providers.Clear();

            string _ErrorMessage = string.Empty; 
        
            foreach (string _ProviderLocation in Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.dll"))
                try
                {
                    Assembly _Assembly;
                    _Assembly = Assembly.LoadFrom(_ProviderLocation);

                    foreach (Type _Type in _Assembly.GetTypes())
                    {
                        if (_Type.GetInterface("DbConsoleService.IDbConsoleProvider") == typeof(IDbConsoleProvider))
                            m_Providers.Add(_Type.FullName, (IDbConsoleProvider)Activator.CreateInstance(_Type));
                    }
                }
                catch (Exception ex)
                {
                    _ErrorMessage = _ErrorMessage + ex.Message + Environment.NewLine;  
                }

            if (_ErrorMessage.Length > 0)
                ShowErrorMessage(_ErrorMessage, "Download provider");   
        }

        public void ShowProviders()
        {
            if (m_Providers == null)
                return;

            ListViewProviders.Items.Clear();

            foreach (KeyValuePair<string, IDbConsoleProvider> _Pair in m_Providers)
            {
                ListViewItem _Item;
                _Item = ListViewProviders.Items.Add(_Pair.Key);
                _Item.Tag = _Pair.Value;
                _Item.Checked = false; 
            }
        }

        private void ValidateExecuteButtonState()
        {
            ExecuteButton.Enabled = (m_Manager != null) && (textBoxSQL.Text.Trim().Length > 0); 
        }

        private void ShowErrorMessage(string _Message, string _Caption)
        {
            MessageBox.Show(_Message, _Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);        
        }

        private void ShowInformationMessage(string _Message, string _Caption)
        {
            MessageBox.Show(_Message, _Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseManager()
        {
            if (m_Manager == null)
                return;

            try
            {
                m_Manager.Close();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Close connection");
            }
            finally
            {
                m_Manager = null;
            }

            ClearData(); 
            ConnectionStatusLabel.Text = string.Empty;
            BeginButton.Enabled = false;
            CommitButton.Enabled = false;
            RollbackButton.Enabled = false;
            ExecuteButton.Enabled = false;
        }

        private bool OpenManager(IDbConsoleProvider _Provider)
        {
            ConnectionStringForm _constrForm = new ConnectionStringForm();
            _constrForm.ShowDialog();  

            if (!_constrForm.IsOk)
                return false;

            m_Manager = new DbConsoleManager(_Provider);

            try
            {
                m_Manager.Open(_constrForm.ConnectionString);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Open connection");
                m_Manager = null;
                return false;
            }

            ShowInformationMessage(string.Format("Connection with '{0}' completed.", _constrForm.ConnectionString), "Open connection");
            ConnectionStatusLabel.Text = _constrForm.ConnectionString;
            BeginButton.Enabled = true;
            ValidateExecuteButtonState();

            return true;
        }

        public void ClearData()
        {
            ListViewDataSet.Clear();
            SQLStatusLabel.Text = string.Empty; 
        }

        public void ShowData(IDataReader Reader)
        {
            ListViewDataSet.Clear();

            int _Result = 0;
            bool _CreateColumns = true;
            while (Reader.Read())
            {
                //Создание колонок в списке
                if (_CreateColumns)
                {
                    ListViewDataSet.Columns.Add("").Width = 20;

                    for (int i = 0; i <= Reader.FieldCount - 1; i++)
                        ListViewDataSet.Columns.Add(Reader.GetName(i));

                    _CreateColumns = false;
                }

                ListViewItem NewItem;
                NewItem = ListViewDataSet.Items.Add("");

                for (int i = 0; i <= Reader.FieldCount - 1; i++)
                    NewItem.SubItems.Add(Reader.GetValue(i).ToString());

                _Result++;
            }

            ListViewDataSet.AlignColumns();  
            SQLStatusLabel.Text = string.Format("{0} records selected.", _Result);
        }

        private void ListViewProviders_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            CloseManager();

            if (!e.Item.Checked)
                return;

            foreach (ListViewItem _Item in ListViewProviders.Items)
                if (_Item != e.Item)
                    _Item.Checked = false;


            if (!OpenManager((IDbConsoleProvider)e.Item.Tag))
                e.Item.Checked = false;   
        }

        private void textBoxSQL_TextChanged(object sender, EventArgs e)
        {
            ValidateExecuteButtonState();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_Manager.BeginTransaction(); 
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Begin transaction");
                return;
            }

            BeginButton.Enabled = false; 
            CommitButton.Enabled = true;
            RollbackButton.Enabled = true; 
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_Manager.CommitTransaction(); 
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Commit transaction");
                return;
            }

            BeginButton.Enabled = true;
            CommitButton.Enabled = false;
            RollbackButton.Enabled = false; 
        }

        private void RollbackButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_Manager.RollbackTransaction(); 
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Rollback transaction");
                return;
            }

            BeginButton.Enabled = true;
            CommitButton.Enabled = false;
            RollbackButton.Enabled = false; 
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            string _SQL = textBoxSQL.Text;

            try
            {
                if (_SQL.StartsWith("select", StringComparison.OrdinalIgnoreCase))
                    ShowData(m_Manager.Select(_SQL));
                else
                {
                    ClearData(); 
                    SQLStatusLabel.Text = string.Format("{0} records selected.", m_Manager.Execute(_SQL));
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Execute SQL query");
                return;
            }
        }



        private void ListViewProviders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class DoubleBufferedListView : ListView
    {
        public DoubleBufferedListView()
        {
            this.DoubleBuffered = true;
        }

        public void AlignColumns()
        {
            foreach (ColumnHeader _Column in this.Columns)
                _Column.Width = GetColumnGetColumnPreferredWidth(this, _Column); 
        }

        public static int GetColumnGetColumnPreferredWidth(ListView _ListView, ColumnHeader _Column)
        {
            Label _Label = new Label();
            _Label.Font = _ListView.Font;
            _Label.Text = _Column.Text;

            int _PreferredWidth = _Label.PreferredWidth;

            foreach (ListViewItem _Item in _ListView.Items)
            {
                _Label.Text = _Item.SubItems[_Column.Index].Text;

                if (_Label.PreferredWidth > _PreferredWidth)
                    _PreferredWidth = _Label.PreferredWidth;
            }

            if (_PreferredWidth == 0)
                return 20;

            _PreferredWidth = _PreferredWidth + 10;

            if (_Column.Index == 0)
                _PreferredWidth = _PreferredWidth + 10;

            return _PreferredWidth;
        }

    }
}
