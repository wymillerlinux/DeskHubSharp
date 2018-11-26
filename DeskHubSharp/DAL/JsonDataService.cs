using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;
using System.Xml.Serialization;

namespace DeskHubSharp
{
    public class JsonDataService
    {
        // TODO: Fundamently broken. Will decide what to do with this.

        private string _dataConfig;

        /// <summary>
        /// reads all the things from the json string/data
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Search> ReadAll()
        {
            List<Search> user = new List<Search>();

            try
            {
                using (StreamReader sr = new StreamReader(_dataConfig))
                {
                    string jsonString = sr.ReadToEnd();

                    Search.ItemsItem users = JsonConvert.DeserializeObject<Search.ItemsItem>(_dataConfig);
                    //user = users.items;
                }

            }
            catch (Exception e)
            {
                throw;
            }

            return user;
        }


        public void WriteAll(IEnumerable<User> characters)
        {
            //RootObject rootObject = new RootObject();
            //rootObject.Characters = new Characters();
            //rootObject.Characters.Character = characters as List<Character>;

            //string jsonString = JsonConvert.SerializeObject(rootObject);

            try
            {
                StreamWriter writer = new StreamWriter(_dataConfig);
                using (writer)
                {
                    //writer.WriteLine(jsonString);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public JsonDataService()
        {

        }

        public JsonDataService(string dataFile)
        {
            _dataConfig = dataFile;
        }
    }
}
