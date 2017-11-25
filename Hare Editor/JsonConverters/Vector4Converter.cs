using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace HareEditor {

    public class Vector4Converter : JsonConverter {

        public override bool CanConvert(Type objectType) {
            return objectType == typeof(OpenTK.Vector4);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var temp = JObject.Load(reader);
            return new OpenTK.Vector4(((float?)temp["X"]).GetValueOrDefault(), ((float?)temp["Y"]).GetValueOrDefault(), ((float?)temp["Z"]).GetValueOrDefault(), ((float?)temp["W"]).GetValueOrDefault());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            var vec = (OpenTK.Vector4)value;
            serializer.Serialize(writer, new { X = vec.X, Y = vec.Y, Z = vec.Z, W = vec.W });
        }

    }

}
