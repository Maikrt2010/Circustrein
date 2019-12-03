using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Carnivore : Animal
    {
        public override bool WillIFitt(List<Animal> Allreadyloaded)
        {
            //bool fitts = Allreadyloaded.Exists(x => x.Size <= Size) && Allreadyloaded.Exists(x => x.animaltype == Animaltype.herbivore && x.Size < Size);
            bool fitts = false;
            if (Allreadyloaded.Exists(x => x.animaltype == Animaltype.carnivore))
                foreach (var y in Allreadyloaded)
                {
                    if (y.animaltype == Animaltype.carnivore && y.Size >= Size)
                    {
                        fitts = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            else if(Allreadyloaded.Exists(x => x.animaltype == Animaltype.herbivore))
            {
                foreach (var y in Allreadyloaded)
                {
                    if (y.animaltype == Animaltype.herbivore && y.Size > Size)
                    {
                        fitts = true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            return fitts;
        }
    

        public Carnivore(int animalid, int size, Animaltype type) : base(animalid, size, type)
        {
        }
    }
}
