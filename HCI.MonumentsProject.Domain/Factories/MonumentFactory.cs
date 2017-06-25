using HCI.MonumentsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace HCI.MonumentsProject.Domain.Factories
{
    internal class MonumentFactory
    {
        private string _filesFolderLocation = "";
        private string _entityFileName = "monuments.txt";

        internal List<Monument> Create()
        {
            List<Monument> monuments = new List<Monument>();

            string[] lines = File.ReadAllLines(_filesFolderLocation + _entityFileName);

            foreach (var l in lines)
            {
                string[] tokens = l.Split(',');
                Monument temp = new Monument();

                temp.Id = tokens[0];
                temp.Name = tokens[1];
                temp.Description = tokens[2];
                temp.MonumentTypeId = tokens[3];
                temp.MonumentEra = tokens[4];
                temp.IconPath = tokens[5];
                temp.IsArchaeologicallyProcessed = bool.Parse(tokens[6]);
                temp.IsOnUNESCOList = bool.Parse(tokens[7]);
                temp.IsInPopulatedArea = bool.Parse(tokens[8]);
                temp.TouristStatus = tokens[9];
                temp.YearIncome = float.Parse(tokens[10]);
                temp.DateOfDiscovery = DateTime.Parse(tokens[11]);

                monuments.Add(temp);
            }

            return monuments;
        }
    }
}
