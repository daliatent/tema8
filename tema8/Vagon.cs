using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema8
{
    internal class Vagon
    {
        private int masa;
        private int fabricationYear;

        public Vagon(int masa, int fabricationYear)
        {
            this.masa = masa;
            this.fabricationYear = fabricationYear;
        }
        public int Masa
        {

            get { return masa; }
        }

        public int FabricationYear
        {
            get { return fabricationYear; }
        }
    }

    class GoodsVagon : Vagon
    {
        private string tipMarfa;
        private int capacitate;

        public GoodsVagon(int masa, int fabricationYear, string tipMarfa, int capacitate) : base(masa, fabricationYear)
        {
            this.tipMarfa = tipMarfa;
            this.capacitate = capacitate;
        }

        public override string ToString()
        {
            return $"Tip Marfa: {tipMarfa}, Capacitate: {capacitate} tone, Masa: {Masa}, An Fabricatie: {FabricationYear}";
        }
    }
    class PersonVagon :Vagon
    {
        private int placeNumber;
        private bool doorsAreClosed;

        public PersonVagon(int masa, int fabricationYear, int placeNumber) : base(masa, fabricationYear)
        {
            this.placeNumber = placeNumber;
            this.doorsAreClosed = false;
        }
        
        public void CloseDoor()
        {
            doorsAreClosed = true;
            Console.WriteLine("Doors are closed");
        }
        public void OpenDoor()
        {
            doorsAreClosed = false;
            Console.WriteLine("Doors are opened");
        }
        public override string ToString()
        {
            return $"Numar Locuri: {placeNumber}, Usi: {(doorsAreClosed ? "inchise" : "deschise")}, Masa: {Masa}, An Fabricatie: {FabricationYear}";
        }
    }
    class FirstClassVagon : PersonVagon
    {
        private bool aerConditionatPornit;

        public FirstClassVagon(int masa, int fabricationYear, int placeNumber) : base(masa, fabricationYear, placeNumber)
        {
            aerConditionatPornit = false;
        }

        public void PornireAerConditionat()
        {
            aerConditionatPornit = true;
            Console.WriteLine("Aerul condiționat este pornit.");
        }
        public void OprireAerConditionat()
        {
            aerConditionatPornit = false;
            Console.WriteLine("Aerul conditionat este oprit");
        }
        public override string ToString()
        {
            return base.ToString() + $", Aer condiționat: {(aerConditionatPornit ? "pornit" : "oprit")}";
        }
    }
}
