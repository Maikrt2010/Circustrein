using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Circustrein
{
    public class Wagon
    {
        private IAnimalConnection iAnimalConnection;
        private List<Animal> _loadedAnimals = new List<Animal>();
        private int _maxweight = 10;
        private int _weight = 0;
        public List<Animal> LoadedAnimals
        {
            get => _loadedAnimals;
            set => _loadedAnimals = value;
        }

        public bool LoadWagon()
        {
            bool loaded = false;
            Animal toloadAnimal = iAnimalConnection.Animaltoload(_maxweight-_weight);
            if (toloadAnimal.WillIFitt(_loadedAnimals)) 
            {
                _loadedAnimals.Add(toloadAnimal);
                iAnimalConnection.AnimalLoaded(toloadAnimal);
                loaded = true;
                _weight = _weight + toloadAnimal.Size;
            }
            return loaded;
        }



        public Wagon(IAnimalConnection _iAnimalConnection)
        {
            iAnimalConnection = _iAnimalConnection;
        }
    }
}
