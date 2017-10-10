using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HareEditor {

    class TabPanel : Control{

        #region Control required stuff
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        private static int tabHeight = 28;
        private static int tabMaxWidth = 128;

        public List<Tab> tabs = new List<Tab>();
        private Panel panel1;
        public int currentTab = -1;

        public TabPanel() {
            components = new System.ComponentModel.Container();
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
            if (currentTab > 0 && currentTab < tabs.Count) {
                tabs.ElementAt(currentTab).Draw(this);
            }
        }
        
    }

}
