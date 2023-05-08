using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergaast_UnitTest2_7
{
    // 4
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

        // 5

        public static bool operator ==(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1 is null && tardis2 is null)
                return true;
            if (tardis1 is null || tardis2 is null)
                return false;

            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
                return true;
            else if (tardis1.whichDrWho != 10 && tardis2.whichDrWho == 10)
                return false;

            return tardis1.whichDrWho == tardis2.whichDrWho;
        }

        public static bool operator !=(Tardis tardis1, Tardis tardis2)
        {
            return !(tardis1 == tardis2);
        }

        public static bool operator <(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1 is null)
                throw new ArgumentNullException(nameof(tardis1));
            if (tardis2 is null)
                throw new ArgumentNullException(nameof(tardis2));

            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
                return false;
            else if (tardis1.whichDrWho != 10 && tardis2.whichDrWho == 10)
                return true;

            return tardis1.whichDrWho < tardis2.whichDrWho;
        }

        public static bool operator >(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1 is null)
                throw new ArgumentNullException(nameof(tardis1));
            if (tardis2 is null)
                throw new ArgumentNullException(nameof(tardis2));

            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
                return true;
            else if (tardis1.whichDrWho != 10 && tardis2.whichDrWho == 10)
                return false;

            return tardis1.whichDrWho > tardis2.whichDrWho;
        }

        public static bool operator <=(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1 is null)
                throw new ArgumentNullException(nameof(tardis1));
            if (tardis2 is null)
                throw new ArgumentNullException(nameof(tardis2));

            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
                return false;
            else if (tardis1.whichDrWho != 10 && tardis2.whichDrWho == 10)
                return true;

            return tardis1.whichDrWho <= tardis2.whichDrWho;
        }

        public static bool operator >=(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1 is null)
                throw new ArgumentNullException(nameof(tardis1));
            if (tardis2 is null)
                throw new ArgumentNullException(nameof(tardis2));

            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
                return true;
            else if (tardis1.whichDrWho != 10 && tardis2.whichDrWho == 10)
                return false;

            return tardis1.whichDrWho >= tardis2.whichDrWho;
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


    // 6 and 7

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
