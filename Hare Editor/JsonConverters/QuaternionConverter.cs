using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace HareEditor {

    public class QuaternionConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return objectType == typeof(OpenTK.Quaternion);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var temp = JObject.Load(reader);
            return new OpenTK.Quaternion(((float?)temp["X"]).GetValueOrDefault(), ((float?)temp["Y"]).GetValueOrDefault(), ((float?)temp["Z"]).GetValueOrDefault(), ((float?)temp["W"]).GetValueOrDefault());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            var vec = (OpenTK.Quaternion)value;
            serializer.Serialize(writer, new { X = vec.X, Y = vec.Y, Z = vec.Z, W = vec.W });
        }
    }

}
