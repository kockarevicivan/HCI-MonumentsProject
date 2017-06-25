using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.IO;

namespace HCI.MonumentsProject.Domain.Factories
{
    internal class MonumentTypeFactory
    {
        private string _filesFolderLocation = "";
        private string _entityFileName = "monument_types.txt";

        internal List<MonumentType> Create()
        {
            List<MonumentType> monumentTypes = new List<MonumentType>();

            string[] lines = File.ReadAllLines(_filesFolderLocation + _entityFileName);

            foreach (var l in lines)
            {
                string[] tokens = l.Split(',');
                MonumentType temp = new MonumentType();

                temp.Id = tokens[0];
                temp.Name = tokens[1];
                temp.IconPath = tokens[2];
                temp.Description = tokens[3];

                monumentTypes.Add(temp);
            }

            return monumentTypes;
        }
    }
}
