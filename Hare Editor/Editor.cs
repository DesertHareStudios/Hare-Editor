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

    public partial class Editor : Form {

        public Editor() {
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

        private void Editor_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }

}
