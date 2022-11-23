using System;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WeldingPredictor
{
    [Serializable]
    public class ApplicationSettings
    {
        [XmlElement("PathToModel")]
        public String PathToModel { get; set; }

        [XmlElement("PathToData")]
        public String PathToData { get; set; }

        public ApplicationSettings()
        {
            PathToModel = String.Empty;
            PathToData = String.Empty;
        }
        
        public void DeserializeFromString(String stringData)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                using (TextReader reader = new StringReader(stringData))
                {
                    ApplicationSettings temp = (ApplicationSettings)xmlSerializer.Deserialize(reader);

                    this.PathToModel = temp.PathToModel;
                    this.PathToData = temp.PathToData;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public String SerializeToString()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                StringWriter textWriter = new StringWriter();

                xmlSerializer.Serialize(textWriter, this);
                return textWriter.ToString();
            }
            catch (Exception E)
            {
                return String.Empty;
            }
        }

        public void Load()
        {
            String configFile = Path.Combine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), String.Format(@"{0}.config", Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location))));
            if (File.Exists(configFile))
            {
                try
                {
                    String serializedString = System.IO.File.ReadAllText(configFile);
                    this.DeserializeFromString(serializedString);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        public void Load(string configFile)
        {
            if (File.Exists(configFile))
            {
                try
                {
                    String serializedString = System.IO.File.ReadAllText(configFile);
                    this.DeserializeFromString(serializedString);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        public void Save()
        {
            try
            {
                String configFile = Path.Combine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), String.Format(@"{0}.config", Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location))));

                String serializedString = this.SerializeToString();
                System.IO.File.WriteAllText(configFile, serializedString);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
