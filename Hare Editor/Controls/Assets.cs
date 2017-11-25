using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using HareEngine;
using System.Reflection;

namespace HareEditor {

    public class Assets : DBPanel {

        private List<Label> toAdd = new List<Label>();
        private List<string> filesToCompile = new List<string>();
        private AppDomain userDll;
        private string customPath = "";

        public Assets() {
            CheckForIllegalCrossThreadCalls = false;
        }

        public void SoftReload() {
            if (customPath == "") {
                customPath = Program.editor.Project.Path + "\\Assets\\";
            }
            RecursiveFiles(customPath);
        }

        private void RecursiveFiles(string path) {
            Controls.Clear();
            if (!path.Equals(Program.editor.Project.Path + "\\Assets\\")) {
                Print("..", true, path, "", (o, e) => {
                    string[] pathParts = path.Split('\\');
                    string newPath = "";
                    for (int i = 0; i < pathParts.Length - 1; i++) {
                        newPath += pathParts[i] + "\\";
                    }
                    RecursiveFiles(newPath);
                });
            }
            string[] subdirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string rs in subdirs) {
                string[] ss = rs.Split('\\');
                string s = ss[ss.Length - 1];
                Print(s, true, rs, "", (o, e) => {
                    RecursiveFiles(path + s);
                });
            }
            foreach (string rs in files) {
                string[] ss = rs.Split('\\');
                string s = ss[ss.Length - 1];
                string[] sParts = s.Split('.');
                string extension = (sParts[sParts.Length - 1]).ToLower();
                Print(s, false, rs, extension, null);
            }
            for (int i = toAdd.Count - 1; i >= 0; i--) {
                Controls.Add(toAdd[i]);
            }
            toAdd.Clear();
        }

        private void Print(string t, bool isFolder, string fullPath, string extension, EventHandler OnDoubleClick) {
            Label label = new Label();
            label.Text = t;
            label.Dock = DockStyle.Top;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.ForeColor = Program.colorFont;
            label.BackColor = System.Drawing.Color.Transparent;
            if (OnDoubleClick != null) {
                label.DoubleClick += OnDoubleClick;
            } else {
                //TODO check for extension for proper handling
                switch (extension) {
                    case "hare":
                        label.DoubleClick += (o, e) => { Program.editor.OpenScene(fullPath); };
                        break;
                }
            }
            label.Click += (o, e) => {
                foreach (Control c in Controls) {
                    c.BackColor = System.Drawing.Color.Transparent;
                    c.ForeColor = Program.colorFont;
                }
                label.BackColor = Program.colorAccentDark;
                label.ForeColor = Program.colorAccentFont;
            };
            toAdd.Add(label);
        }

        private void SearchForCode(string path) {
            string[] subdirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string rs in subdirs) {
                string[] ss = rs.Split('\\');
                string s = ss[ss.Length - 1];
                SearchForCode(path + s);
            }
            foreach (string file in files) {
                string[] ss = file.Split('\\');
                string s = ss[ss.Length - 1];
                string[] sParts = s.Split('.');
                string extension = (sParts[sParts.Length - 1]).ToLower();
                if (extension.ToLower() == "cs") {
                    filesToCompile.Add(file);
                }
            }
        }

        public void Reload() {
            SearchForCode(Program.editor.Project.Path + "\\Assets\\");
            SoftReload();
            HareEngine.Asset.AutoRead(Program.editor.Project.Path + "\\Assets\\");
            if (filesToCompile.Count > 0) {
                try {
                    CSharpCodeProvider provider = new CSharpCodeProvider();
                    CompilerParameters parameters = new CompilerParameters();
                    parameters.ReferencedAssemblies.Add(Directory.GetCurrentDirectory() + "\\Hare Engine.dll");
                    parameters.ReferencedAssemblies.Add(Directory.GetCurrentDirectory() + "\\OpenTK.dll");
                    parameters.GenerateExecutable = false;
                    parameters.GenerateInMemory = false;
                    parameters.OutputAssembly = Program.editor.Project.Path + "\\Temp\\user.dll";
                    CompilerResults results = provider.CompileAssemblyFromFile(parameters, filesToCompile.ToArray());
                    foreach (CompilerError error in results.Errors) {
                        if (error.IsWarning) {
                            Debug.Warning("Warning (" + error.ErrorNumber + ") @" + error.FileName + ":" + error.Line + "\n" + error.ErrorText);
                        } else {
                            Debug.Error("Error (" + error.ErrorNumber + ") @" + error.FileName + ":" + error.Line + "\n" + error.ErrorText);
                        }
                    }
                    if (!results.Errors.HasErrors) {
                        if (userDll != null) {
                            AppDomain.Unload(userDll);
                            userDll = null;
                        }
                        userDll = AppDomain.CreateDomain("UserDll");
                        userDll.UnhandledException += (o, e) => {
                            Debug.Exception((Exception)e.ExceptionObject);
                        };
                        SimpleAssemblyLoader assemblyLoader = (SimpleAssemblyLoader)userDll.CreateInstanceAndUnwrap(typeof(SimpleAssemblyLoader).Assembly.FullName, typeof(SimpleAssemblyLoader).FullName);
                        assemblyLoader.LoadFrom(results.CompiledAssembly.Location);
                    }
                } catch (Exception e) {
                    Debug.Exception(e);
                }
            }
            filesToCompile.Clear();

        }
    }

    public class SimpleAssemblyLoader : MarshalByRefObject {
        public void Load(string path) {
            ValidatePath(path);

            Assembly.Load(path);
        }

        public void LoadFrom(string path) {
            ValidatePath(path);

            Assembly.LoadFrom(path);
        }

        private void ValidatePath(string path) {
            if (path == null) throw new ArgumentNullException("path");
            if (!System.IO.File.Exists(path))
                throw new ArgumentException(String.Format("Path \"{0}\" does not exist", path));
        }
    }

}
