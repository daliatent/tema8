using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema8
{
    internal class Tren
    {
        private string name;
        private Locomotiva locomotiva;
        private List<Vagon> vagoane;

        public Tren(string nume)
        {
            this.name = nume;
            this.locomotiva= new Locomotiva();
            this.vagoane= new List<Vagon>();
        }

        public void AddVagon(Vagon vagon)
        {
            vagoane.Add(vagon);
            Console.WriteLine("Vagon adaugat:" + vagon);
        }

        public void LeaveStation()
        {
            Console.WriteLine("Trenul "+ name + "pleaca din gara.");

            foreach(var vagon in vagoane)
            {
                if(vagon is PersonVagon personVagon)
                {
                    personVagon.CloseDoor();
                }
            }
            locomotiva.Start();
        }

        public void StopInStation()
        {
            Console.WriteLine("Trenul "+name+ "opreste in gara");
            locomotiva.Stop();

            foreach(var vagon in vagoane)
            {
                if(vagon is PersonVagon personVagon)
                {
                    personVagon.OpenDoor();
                }

                if(vagon is FirstClassVagon firstClassVagon)
                {
                    firstClassVagon.OprireAerConditionat();
                }
            }
        }
    }
}
