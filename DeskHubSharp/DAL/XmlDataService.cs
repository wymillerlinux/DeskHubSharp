using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DeskHubSharp
{
    class XmlDataService
    {
        private readonly string _dataFilePath;

        public List<User> ReadAll()
        {
            List<User> Users = new List<User>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>), new XmlRootAttribute("Users"));

            try
            {
                StreamReader reader = new StreamReader(_dataFilePath);
                using (reader)
                {
                    Users = (List<User>)serializer.Deserialize(reader);
                }

            }
            catch (Exception)
            {
                throw;
            }

            return Users;
        }

        public void WriteAll(List<User> Users)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>), new XmlRootAttribute("Users"));

            try
            {
                StreamWriter writer = new StreamWriter(_dataFilePath);
                using (writer)
                {
                    serializer.Serialize(writer, Users);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public XmlDataService()
        {

        }

        public XmlDataService(string datafile)
        {
            _dataFilePath = datafile;
        }
    }
}
