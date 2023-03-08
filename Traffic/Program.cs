using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Pendergast_PE11;

namespace Traffic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPassengerCarrier iPassengerCarrier = null;
            Compact compact = new Compact();
            FreightTrain freightTrain = new FreightTrain();
            AddPassenger(compact);
            AddPassenger(freightTrain);

            void AddPassenger(object vehicleObject)
            {
                iPassengerCarrier = (IPassengerCarrier) vehicleObject;
                iPassengerCarrier.LoadPassenger();
                Console.WriteLine(vehicleObject.ToString());
            }
        }
    }
}
