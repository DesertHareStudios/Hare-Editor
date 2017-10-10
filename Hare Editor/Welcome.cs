﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareEditor {

    public partial class Welcome : Form {

        public Welcome() {
            Program.welcome = this;
            InitializeComponent();
            switch (EditorPrefs.Instance.theme) {
                case Theme.Light:
                    BackColor = Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = Color.FromArgb(157, 157, 157);
                    break;
                case Theme.Dark:
                    BackColor = Color.FromArgb(37, 37, 37);
                    Appbar.BackColor = Color.FromArgb(15, 15, 15);
                    break;
                case Theme.Hybrid:
                    BackColor = Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = Color.FromArgb(37, 37, 37);
                    break;
            }
        }

        private void btnNew_Click(object sender, EventArgs e) {
            //TODO Prompt project name
            //Temporal code for testing...
            this.Hide();
            Program.editor.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            //TODO search for projects
        }

        private void Welcome_Load(object sender, EventArgs e) {
            //TODO load recent projects
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }

}
