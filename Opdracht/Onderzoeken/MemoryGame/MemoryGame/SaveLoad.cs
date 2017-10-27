using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace MemoryGame
{
    public class SaveLoad
    {
        //public static void SaveData(object Iclass, String Filename)
        //{
        //StreamWriter writer = null;
        //try
        //{
        //XmlSerializer xmlSerializer = new XmlSerializer((Iclass.GetType()));
        // writer = new StreamWriter(Filename);
        //   XmlSerializer.GenerateSerializer(writer, Iclass);
        //}
        //finally
        //{
        //  if (writer != null)
        //        writer.Close();
        //      writer = null;
        //    }  
        //  }
        //}
        public class Xmlload<T>
        {
            public static Type type;

            public Xmlload()
            {
                type = typeof(T);
            }
            public T LoadData(string filename)
            {
                T result;
                XmlSerializer xmlSerializer = new XmlSerializer(type);
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                result = (T)xmlSerializer.Deserialize(fs);
                fs.Close();
                return result;
            }
        }
    }
}
