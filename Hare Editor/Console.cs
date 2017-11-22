using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HareEngine;

namespace HareEditor {

    public partial class Console : Form {

        private static Console instance;

        public static List<Debug.Message> messages = new List<Debug.Message>();

        public static Console Instance {
            get {
                if (instance == null) {
                    instance = new Console();
                }
                return instance;
            }
        }

        private Console() {
            InitializeComponent();
            Reload();
        }

        public void Reload() {
            BackColor = Program.colorSecondary;
            Appbar.BackColor = Program.colorPrimary;
            btnClear.ForeColor = Program.colorAccentFont;
            cbxError.ForeColor = Program.colorAccentFont;
            cbxLog.ForeColor = Program.colorAccentFont;
            cbxWarning.ForeColor = Program.colorAccentFont;
            Wrapper.Controls.Clear();
            foreach (Debug.Message msg in messages) {
                if (msg.Type == Debug.MessageType.Error && cbxError.Checked ||
                    msg.Type == Debug.MessageType.Log && cbxLog.Checked ||
                    msg.Type == Debug.MessageType.Warning && cbxWarning.Checked) {
                    if (tbxSearch.Text == "" || msg.Text.ToLower().Contains(tbxSearch.Text.ToLower()) || msg.Text != "") {
                        GrowLabel lbl = new GrowLabel();
                        lbl.Dock = DockStyle.Top;
                        lbl.Text = msg.Text;
                        switch (msg.Type) {
                            case Debug.MessageType.Error:
                                lbl.ForeColor = System.Drawing.Color.Red;
                                break;
                            case Debug.MessageType.Warning:
                                lbl.ForeColor = System.Drawing.Color.Yellow;
                                break;
                            case Debug.MessageType.Log:
                            default:
                                lbl.ForeColor = Program.colorFont;
                                break;
                        }
                        DBPanel margin = new DBPanel();
                        margin.Dock = DockStyle.Top;
                        margin.Height = 1;
                        margin.BackColor = System.Drawing.Color.Black;
                        Wrapper.Controls.Add(margin);
                        Wrapper.Controls.Add(lbl);
                    }
                }
            }
        }

        private void Search(object sender, EventArgs e) {
            Reload();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            messages.Clear();
            Wrapper.Controls.Clear();
        }

        private void Console_FormClosed(object sender, FormClosedEventArgs e) {
            instance = null;
        }
    }

}
