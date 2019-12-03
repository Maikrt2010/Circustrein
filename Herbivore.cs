using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Herbivore : Animal
    {
        public override bool WillIFitt(List<Animal> Allreadyloaded)
        { 
        //bool fitts = Allreadyloaded.Exists(x => x.animaltype == Animaltype.carnivore && x.Size < Size );
        bool fitts = false;
        if(Allreadyloaded.Exists(x => x.animaltype == Animaltype.carnivore))
            foreach (var y in Allreadyloaded)
            {
                if (y.animaltype == Animaltype.carnivore && y.Size > Size)
                {
                    return false;
                }
                else
                {
                    fitts = true;
                }
            }
        else
        {
            return true;
        }

        return fitts;
        }

        public Herbivore(int animalid, int size, Animaltype type) : base(animalid, size, type)
        {
        }
    }
}
