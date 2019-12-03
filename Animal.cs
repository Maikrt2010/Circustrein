using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public abstract class Animal
    {
        private int _animalid;
        private int _size;
        private Animaltype _animaltype;

        public int Animalid => _animalid;

        public int Size => _size;

        public Animaltype animaltype => _animaltype;

        public Animal(int animalid, int size, Animaltype type)
        {
            _animalid = animalid;
            _size = size;
            _animaltype = type;
        }

        public abstract bool WillIFitt(List<Animal> Allreadyloaded);
    }

}
