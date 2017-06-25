using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.IO;

namespace HCI.MonumentsProject.Domain.Factories
{
    internal class MonumentTagFactory
    {
        private string _filesFolderLocation = "";
        private string _entityFileName = "monument_tags.txt";

        internal List<MonumentTag> Create()
        {
            List<MonumentTag> monumentTags = new List<MonumentTag>();

            string[] lines = File.ReadAllLines(_filesFolderLocation + _entityFileName);

            foreach (var l in lines)
            {
                string[] tokens = l.Split(',');
                MonumentTag temp = new MonumentTag();

                temp.MonumentId = tokens[0];
                temp.TagId = tokens[1];

                monumentTags.Add(temp);
            }

            return monumentTags;
        }
    }
}
