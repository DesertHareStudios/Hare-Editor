using System.IO;
using System.Collections.Generic;

namespace HareEditor {

    public class Asset {
        private List<AssetProperty> data;

        public Asset() {
            data = new List<AssetProperty>();
        }

        public string GetString(string name, string defaultValue) {
            foreach (AssetProperty ap in data) {
                if (ap.Name == name) {
                    return ap.Value;
                }
            }
            PutString(name, defaultValue);
            return defaultValue;
        }

        public Asset PutString(string name, string value) {
            foreach (AssetProperty ap in data) {
                if (ap.Name == name) {
                    ap.Value = value;
                    return this;
                }
            }
            data.Add(new AssetProperty(name, value));
            return this;
        }

        public bool GetBool(string name, bool defaultValue) {
            return bool.Parse(GetString(name, defaultValue.ToString()));
        }

        public Asset PutBool(string name, bool value) {
            return PutString(name, value.ToString());
        }

        public int GetInt(string name, int defaultValue) {
            int output;
            if (int.TryParse(GetString(name, defaultValue.ToString()), out output)) {
                return output;
            }
            return defaultValue;
        }

        public Asset PutInt(string name, int value) {
            return PutString(name, value.ToString());
        }

        public float GetFloat(string name, float defaultValue) {
            float output;
            if (float.TryParse(GetString(name, defaultValue.ToString()), out output)) {
                return output;
            }
            return defaultValue;
        }

        public Asset PutFloat(string name, float value) {
            return PutString(name, value.ToString());
        }

        public bool SaveToFile(string path) {
            string datastring = "";
            foreach (AssetProperty ap in data) {
                datastring += ap.Name + "=" + ap.Value + "\n";
            }
            try {
                File.WriteAllText(path, datastring);
                return true;
            } catch {
                return false;
            }
        }

        public static Asset ReadFromFile(string path) {
            Asset output = new Asset();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++) {
                try {
                    string[] values = lines[i].Split('=');
                    output.data.Add(new AssetProperty(values[0], values[1]));
                } catch { }
            }
            return output;
        }

    }

    class AssetProperty {
        public string Name;
        public string Value;
        public AssetProperty(string name, string value) {
            Name = name;
            Value = value;
        }
    }

}
