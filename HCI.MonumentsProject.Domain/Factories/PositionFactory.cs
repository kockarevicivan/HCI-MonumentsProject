using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.IO;

namespace HCI.MonumentsProject.Domain.Factories
{
    internal class PositionFactory
    {
        private string _filesFolderLocation = "";
        private string _entityFileName = "positions.txt";

        internal List<Position> Create()
        {
            List<Position> positions = new List<Position>();

            string[] lines = File.ReadAllLines(_filesFolderLocation + _entityFileName);

            foreach (var l in lines)
            {
                string[] tokens = l.Split(',');
                Position temp = new Position();

                temp.MonumentId = tokens[0];
                temp.XPosition = float.Parse(tokens[1]);
                temp.YPosition = float.Parse(tokens[2]);

                positions.Add(temp);
            }

            return positions;
        }
    }
}
