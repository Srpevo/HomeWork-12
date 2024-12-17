using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12.Core.Classes.FileIoTools
{
    internal static class FileIoTools
    {
        public static void Write(string content, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(content);
            }
        }
        public static string Read(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                return sr.ReadToEnd();
            }
        }

    }
}
