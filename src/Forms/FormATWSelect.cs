﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRACTool_Reloaded
{
    public partial class FormATWSelect : Form
    {
        public FormATWSelect()
        {
            InitializeComponent();
        }

        private void FormATWSelect_Load(object sender, EventArgs e)
        {
            comboBox_fmt.SelectedIndex = 0;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Common.Generic.WTAFlag = comboBox_fmt.SelectedIndex;
            Close();
        }
    }
}
