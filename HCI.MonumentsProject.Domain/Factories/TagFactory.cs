using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.IO;

namespace HCI.MonumentsProject.Domain.Factories
{
    internal class TagFactory
    {
        private string _filesFolderLocation = "";
        private string _entityFileName = "tags.txt";

        internal List<Tag> Create()
        {
            List<Tag> tags = new List<Tag>();

            string[] lines = File.ReadAllLines(_filesFolderLocation + _entityFileName);

            foreach (var l in lines)
            {
                string[] tokens = l.Split(',');
                Tag temp = new Tag();

                temp.Id = tokens[0];
                temp.Color = tokens[1];
                temp.Description = tokens[2];

                tags.Add(temp);
            }

            return tags;
        }
    }
}
