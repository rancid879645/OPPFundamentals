
using Newtonsoft.Json;

namespace Alexandria.Deserializer
{
    public class Deserializer:IDeserializer
    {
        public object? DeserializeJson(string filePath)
        {
            var content = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject(content);
        }
    }
}
