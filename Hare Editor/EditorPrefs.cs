using HareEngine;

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

        public Color tint = new Color(0f, 0.618f, 0.618f);

        public Theme theme;

        private EditorPrefs() {
            theme = Theme.Dark;
        }

    }

    public enum Theme {
        Light,
        Dark,
        Hybrid
    }

}
