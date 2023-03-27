using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergaast_UnitTest2_7
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string Address;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public abstract void Connect();
        public abstract void Disconnect();
    }

    public interface IPhone
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public class RotaryPhone : Phone, IPhone
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    public class PushButtonPhone : Phone, IPhone
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }

        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }

        public void TimeTravel() { }



        public static bool operator ==(Tardis t1, Tardis t2)
        {
            if (t1 is null && t2 is null)
                return true;
            if (t1 is null || t2 is null)
                return false;

            if (t1.whichDrWho == 10 && t2.whichDrWho != 10)
                return true;
            else if (t1.whichDrWho != 10 && t2.whichDrWho == 10)
                return false;

            return t1.whichDrWho == t2.whichDrWho;
        }

        public static bool operator !=(Tardis t1, Tardis t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Tardis t1, Tardis t2)
        {
            if (t1 is null)
                throw new ArgumentNullException(nameof(t1));
            if (t2 is null)
                throw new ArgumentNullException(nameof(t2));

            if (t1.whichDrWho == 10 && t2.whichDrWho != 10)
                return false;
            else if (t1.whichDrWho != 10 && t2.whichDrWho == 10)
                return true;

            return t1.whichDrWho < t2.whichDrWho;
        }

        public static bool operator >(Tardis t1, Tardis t2)
        {
            if (t1 is null)
                throw new ArgumentNullException(nameof(t1));
            if (t2 is null)
                throw new ArgumentNullException(nameof(t2));

            if (t1.whichDrWho == 10 && t2.whichDrWho != 10)
                return true;
            else if (t1.whichDrWho != 10 && t2.whichDrWho == 10)
                return false;

            return t1.whichDrWho > t2.whichDrWho;
        }

        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if (t1 is null)
                throw new ArgumentNullException(nameof(t1));
            if (t2 is null)
                throw new ArgumentNullException(nameof(t2));

            if (t1.whichDrWho == 10 && t2.whichDrWho != 10)
                return false;
            else if (t1.whichDrWho != 10 && t2.whichDrWho == 10)
                return true;

            return t1.whichDrWho <= t2.whichDrWho;
        }

        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if (t1 is null)
                throw new ArgumentNullException(nameof(t1));
            if (t2 is null)
                throw new ArgumentNullException(nameof(t2));

            if (t1.whichDrWho == 10 && t2.whichDrWho != 10)
                return true;
            else if (t1.whichDrWho != 10 && t2.whichDrWho == 10)
                return false;

            return t1.whichDrWho >= t2.whichDrWho;
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() { }
        public void CloseDoor() { }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);
        }

        static void UsePhone(object obj)
        {
            if (obj is IPhone)
            {
                IPhone phone = (IPhone)obj;

                phone.MakeCall();
                phone.HangUp();
            }

            if (obj is PhoneBooth)
            {
                PhoneBooth phoneBooth = (PhoneBooth)obj;
                phoneBooth.OpenDoor();
            }
            else if (obj is Tardis)
            {
                Tardis tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
    }
}
