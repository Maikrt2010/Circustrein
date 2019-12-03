using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public interface ITrain
    {
        void Loadanimals();
        List<Wagon> ShowWagons();
    }

    public class Train : ITrain
    {
        private IAnimalConnection iAnimalConnection;
        private List<Wagon> wagons = new List<Wagon>();
        private Wagon currentWagon;

        public void Loadanimals()
        {
            currentWagon = new Wagon(iAnimalConnection);
            wagons.Add(currentWagon);
            int animalstoload = iAnimalConnection.Loadammount();
            int i = 0;
            while (animalstoload != i)
            {
                bool hasloaded = currentWagon.LoadWagon();
                if (hasloaded == true)
                {
                    i++;
                }
                else if (hasloaded == false)
                {
                    currentWagon = new Wagon(iAnimalConnection);
                    wagons.Add(currentWagon);
                }
            }
        }

        public List<Wagon> ShowWagons()
        {
            return wagons;
        }


        public Train(IAnimalConnection _IanimalConnection)
        {
            iAnimalConnection = _IanimalConnection;
        }

    }
}
