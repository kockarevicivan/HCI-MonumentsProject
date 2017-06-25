using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;

namespace HCI.MonumentsProject.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            IPositionManager positionManager = new PositionManager();
            IMonumentManager monumentManager = new MonumentManager();
            
        }
    }
}
