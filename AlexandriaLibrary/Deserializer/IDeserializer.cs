namespace Alexandria.Deserializer
{
    public interface IDeserializer
    {
        public object? DeserializeJson(string filePath);
    }
}
