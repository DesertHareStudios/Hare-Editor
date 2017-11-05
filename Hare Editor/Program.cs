using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Reflection;
//using HareEngine;
//using HareEngine.SceneManagement;
//using OpenTK;

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
            //Hare.Init(400, 400, "Test");
            //Scene scene = new Scene("Test");
            //GameObject c = new GameObject("Camera");
            //c.transform.position = new OpenTK.Vector3(0f, 0f, -10f);
            //GameObject s = new GameObject("sprite");
            //Camera cam = new Camera(c);
            //cam.viewmode = Viewmode.Orthographic;
            //c.AddBehaviour(cam);
            //s.AddBehaviour(new SpriteRenderer(s));
            //s.AddBehaviour(new TestBehaviour(s));
            //c.transform.position = new OpenTK.Vector3(0f, 0f, -10f);
            //scene.gameObjects.Add(c);
            //scene.gameObjects.Add(s);
            //scene.Preload = () => {
            //    Texture t = new Texture(Environment.CurrentDirectory + "\\logo.png");
            //    s.GetComponent<SpriteRenderer>().sprite = t;
            //};
            //SceneManager.AddScene(scene);
            //SceneManager.LoadScene("Test");
            //Hare.Run();
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

    //public class TestBehaviour : Behaviour {

    //    private Vector3 target = new Vector3();

    //    public TestBehaviour(GameObject gameObject) : base(gameObject) { }

    //    public override void Update() {
    //        if (Input.GetKeyDown(OpenTK.Input.Key.W)) {
    //            target.Y += .5f;
    //        }
    //        if (Input.GetKeyDown(OpenTK.Input.Key.A)) {
    //            target.X -= .5f;
    //        }
    //        if (Input.GetKeyDown(OpenTK.Input.Key.S)) {
    //            target.Y -= .5f;
    //        }
    //        if (Input.GetKeyDown(OpenTK.Input.Key.D)) {
    //            target.X += .5f;
    //        }
    //        if (Input.GetKeyDown(OpenTK.Input.Key.Q)) {
    //            target.Z += .5f;
    //        }
    //        if (Input.GetKeyDown(OpenTK.Input.Key.E)) {
    //            target.Z -= .5f;
    //        }
    //        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);
    //    }
    //}

    public class ProjectHolder {
        public string Name;
        public string Path;

        public ProjectHolder(string name, string path) {
            Name = name;
            Path = path;
        }
    }

}
