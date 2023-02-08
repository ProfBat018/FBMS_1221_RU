using Lesson3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Service
{
    public class FileService
    {
        public static string? ReadFromFile(string? path, FileMode fileMode)
        {
            using FileStream fs = new(path, fileMode);
            using StreamReader sr = new(fs);
            
            return sr.ReadToEnd();
        }
        
        public static void WriteToFile(string? json, string? path, FileMode fileMode)
        {
            using FileStream fs = new(path, fileMode);
            using StreamWriter sw = new(fs);

            sw.Write(json);
        }
    }
}
