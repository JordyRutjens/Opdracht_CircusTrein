using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_CircusTrein
{
    class Animal
    {

        private Form_Main.AnimalSize animalSize;
        private Form_Main.AnimalType animalType;
        public int animalValue;

        public Form_Main.AnimalSize GetAnimalSize
        {
            get { return animalSize; }
            set { animalSize = value; }
        }
        public Form_Main.AnimalType GetAnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        //public void setAnimal(Form_Main.AnimalType type, Form_Main.AnimalSize size)
        //{
        //    animalSize = size;
        //    animalType = type;

        //}

        public int PointsToAdd { get; private set; }

        public Animal(Form_Main.AnimalType type, Form_Main.AnimalSize size)
        {
            animalSize = size;
            animalType = type;
            animalValue = Convert.ToInt32(size);

            switch (GetAnimalSize)
            {
                case Form_Main.AnimalSize.Small:
                    PointsToAdd = 1;
                    break;
                case Form_Main.AnimalSize.Medium:
                    PointsToAdd = 3;
                    break;
                case Form_Main.AnimalSize.Large:
                    PointsToAdd = 5;
                    break;
            }
        }
        public override string ToString()
        {
            return $"FoodType: {animalType} | Size: {animalSize} | Points: {PointsToAdd}";
        }
    }
}
