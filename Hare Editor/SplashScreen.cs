using System.Threading;
using System.Windows.Forms;

namespace HareEditor {

    public partial class SplashScreen : Form {

        private static Thread SplashThread;
        private static SplashScreen instance;

        public static void ShowSplash() {
            if (SplashThread == null) {
                instance = new SplashScreen();
                SplashThread = new Thread(() => {
                    Application.Run(instance);
                });
            }
            SplashThread.IsBackground = true;
            SplashThread.Start();
        }

        public static void HideSplash() {
            if (instance != null) {
                instance.Close();
                SplashThread.Abort();
                instance = null;
                SplashThread = null;
            }
        }

        private SplashScreen() {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

    }

}
