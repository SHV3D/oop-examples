﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void CloseThisWindow(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
