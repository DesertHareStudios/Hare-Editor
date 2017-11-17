using System.IO;

namespace HareEditor {

    public class EditorPrefs {

        #region Singleton
        private static EditorPrefs instance;

        public static EditorPrefs Instance {
            get {
                if (instance == null) {
                    instance = new EditorPrefs();
                }
                return instance;
            }
        }
        #endregion

        private Asset data;

        public Theme theme;

        private EditorPrefs() { }

        public void Save() {
            if (data == null) {
                data = new Asset();
            }
            data.PutInt("theme", (int)theme);
            data.SaveToFile(Directory.GetCurrentDirectory() + "\\EditorPrefs.asset");
        }

        public void Load() {
            data = Asset.ReadFromFile(Directory.GetCurrentDirectory() + "\\EditorPrefs.asset");
            theme = (Theme)data.GetInt("theme", (int)Theme.Hybrid);
        }

    }

    public enum Theme {
        Light,
        Dark,
        Hybrid
    }

}
