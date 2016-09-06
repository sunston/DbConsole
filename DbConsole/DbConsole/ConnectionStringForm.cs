using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DbConsole
{
    public partial class ConnectionStringForm : Form
    {
        bool m_Ok = false;
        public ConnectionStringForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            m_Ok = true;
            this.Close(); 
        }

        public bool IsOk
        {
            get { return m_Ok; }
        }

        public string ConnectionString
        {
            get { return textBoxConnectionString.Text; }
        }
    }
}
