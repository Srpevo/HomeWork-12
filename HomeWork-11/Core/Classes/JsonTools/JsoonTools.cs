using System.Text.Json;

namespace HomeWork_12.Core.Classes.JsonTools
{
    internal static class JsonTools
    {
        public static void ToJson<T>(T obj, string path) where T : class
        {
            if (string.IsNullOrEmpty(path)) return;

            string jsonString = JsonSerializer.Serialize(obj);

            FileIoTools.FileIoTools.Write(jsonString, path);
        }

        public static T ToObj<T>(string path) where T : class
        {
            if (string.IsNullOrEmpty(path)) return null!;

            string jsonString = FileIoTools.FileIoTools.Read(path);

            return JsonSerializer.Deserialize<T>(jsonString)!;
        }
    }
}
