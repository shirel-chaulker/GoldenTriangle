using System;
using System.IO;

namespace MyApp.Utilities
{
    public class FilesIO
    {
        private string path;

        public FilesIO(string path)
        {
            this.path = path;
        }
        public string ReadText(string file)
        {
            using (TextReader reader = File.OpenText(path + file))
            {
                return reader.ReadToEnd();
            }
        }

        public void WriteText(string file,string text)
            //which file i want to write and which text i want to write
        {
            using (TextWriter writer = File.CreateText(path + file))
            {
                writer.Write(text);
            }
        }
        //IO - is a short of input output
    }
}
