using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HareEditor {

    static class Program {

        private static Editor _editor;

        public static Editor editor {
            get {
                if (_editor == null) {
                    _editor = new Editor();
                }
                return _editor;
            }
        }

        private static CreateProject _cProject;

        public static CreateProject cProject {
            get {
                if (_cProject == null) {
                    _cProject = new CreateProject();
                }
                return _cProject;
            }
        }

        public static Welcome welcome;

        public static List<ProjectHolder> recentProjects = new List<ProjectHolder>();

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenTK.Toolkit.Init();
            Application.Run(new Welcome());
        }

        public static void SaveProjectList() {
            string text = "";
            foreach (ProjectHolder ph in Program.recentProjects) {
                text += ph.Name + "\n" + ph.Path + "\n";
            }
            File.WriteAllText(Environment.CurrentDirectory + "\\rpl.list", text);
        }

        public static System.Drawing.Color HareColorToNETColor(HareEngine.Color color) {
            return System.Drawing.Color.FromArgb(
                    (int)(color.a * 255),
                    (int)(color.r * 255),
                    (int)(color.g * 255),
                    (int)(color.b * 255)
                );
        }

        public static HareEngine.Color NETColorToHareColor(System.Drawing.Color color) {
            return new HareEngine.Color(
                    (float)color.R / 255f,
                    (float)color.G / 255f,
                    (float)color.B / 255f,
                    (float)color.A / 255f
                );
        }

    }

    public class ProjectHolder {
        public string Name;
        public string Path;

        public ProjectHolder(string name, string path) {
            Name = name;
            Path = path;
        }
    }

}
