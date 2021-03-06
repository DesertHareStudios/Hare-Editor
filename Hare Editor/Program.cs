using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Reflection;
using HareEngine;

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

        private static Gameview _game;

        public static Gameview Gameview {
            get {
                if (_game == null) {
                    _game = new Gameview();
                }
                return _game;
            }
            set {
                _game = value;
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

        public static System.Drawing.Color colorPrimary;
        public static System.Drawing.Color colorSecondary;
        public static System.Drawing.Color colorAccent;
        public static System.Drawing.Color colorAccentDark {
            get {
                return System.Drawing.Color.FromArgb(255, (int)(colorAccent.R * 0.9f), (int)(colorAccent.G * 0.9f), (int)(colorAccent.B * 0.9f));
            }
        }
        public static System.Drawing.Color colorAccentFont;
        public static System.Drawing.Color colorFont;
        public static System.Drawing.Color colorInvertedFont {
            get {
                return System.Drawing.Color.FromArgb(255, 255 - colorFont.R, 255 - colorFont.G, 255 - colorFont.B);
            }
        }

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenTK.Toolkit.Init();
            EditorPrefs.Instance.Load();
            ReloadColors();
            Debug.Register((type, msg) => {
                string head = "";
                switch (type) {
                    case Debug.MessageType.Error:
                        head = "ERROR: ";
                        break;
                    case Debug.MessageType.Warning:
                        head = "Warning: ";
                        break;
                }
                System.Console.WriteLine(head + msg);
                Console.messages.Add(new Debug.Message(type, msg));
                Console.Instance.Reload();
            });
            Application.Run(new Welcome());
        }

        [System.Runtime.InteropServices.DllImport("Shell32.dll")]
        private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

        public static void ReloadColors() {
            switch (EditorPrefs.Instance.theme) {
                case Theme.Light:
                    colorSecondary = System.Drawing.Color.FromArgb(210, 210, 210);
                    colorPrimary = System.Drawing.Color.FromArgb(155, 0, 158, 255);
                    colorFont = System.Drawing.Color.FromArgb(15, 15, 15);
                    colorAccent = System.Drawing.Color.FromArgb(155, 0, 158, 255);
                    colorAccentFont = System.Drawing.Color.FromArgb(240, 240, 240);
                    break;
                case Theme.Dark:
                    colorSecondary = System.Drawing.Color.FromArgb(37, 37, 37);
                    colorPrimary = System.Drawing.Color.FromArgb(15, 15, 15);
                    colorFont = System.Drawing.Color.FromArgb(240, 240, 240);
                    colorAccent = System.Drawing.Color.FromArgb(155, 0, 158, 255);
                    colorAccentFont = System.Drawing.Color.FromArgb(240, 240, 240);
                    break;
                case Theme.Hybrid:
                    colorSecondary = System.Drawing.Color.FromArgb(200, 200, 200);
                    colorPrimary = System.Drawing.Color.FromArgb(15, 15, 15);
                    colorFont = System.Drawing.Color.FromArgb(15, 15, 15);
                    colorAccent = System.Drawing.Color.FromArgb(155, 0, 158, 255);
                    colorAccentFont = System.Drawing.Color.FromArgb(240, 240, 240);
                    break;
            }
        }

        public static void SaveProjectList() {
            string text = "";
            foreach (ProjectHolder ph in Program.recentProjects) {
                text += ph.Name + "\n" + ph.Path + "\n";
            }
            File.WriteAllText(Environment.CurrentDirectory + "\\rpl.list", text);
        }

        public static string CurrentVersion {
            get {
                return ApplicationDeployment.IsNetworkDeployed
                       ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                       : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static System.Drawing.Color HareColorToNETColor(Color color) {
            return System.Drawing.Color.FromArgb(
                    (int)Mathf.Clamp(color.a * 255, 0, 255),
                    (int)Mathf.Clamp(color.r * 255, 0, 255),
                    (int)Mathf.Clamp(color.g * 255, 0, 255),
                    (int)Mathf.Clamp(color.b * 255, 0, 255)
                );
        }

        public static Color NETColorToHareColor(System.Drawing.Color color) {
            return new Color(
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
