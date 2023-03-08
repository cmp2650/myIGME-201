using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE11
{
    public abstract class Vehicle
    {
        public virtual void LoadPassenger() { }
    }
    public abstract class Car : Vehicle
    {

    }
    public abstract class Train : Vehicle
    {

    }
    public class Compact : Car, IPassengerCarrier
    {

    }
    public class SUV : Car, IPassengerCarrier
    {

    }
    public class Pickup : Car, IPassengerCarrier
    {

    }
    public class PassengerTrain : Train, IPassengerCarrier
    {

    }
    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }
    public class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }
    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }
    public interface IHeavyLoadCarrier
    {

    }
}
