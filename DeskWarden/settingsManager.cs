using System.IO;
using System.Xml.Serialization;

namespace DeskWarden
{
    public class settingsManager
    {
        public static void settingsWriter(object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }

        //Userdata xml reader
        public static settings settingsReader(string filename)
        {
            settings obj = new settings();
            XmlSerializer xs = new XmlSerializer(typeof(settings));
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            obj = (settings)xs.Deserialize(reader);
            reader.Close();
            return obj;
        }
    }
}
