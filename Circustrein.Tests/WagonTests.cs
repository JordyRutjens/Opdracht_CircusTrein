using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Opdracht_CircusTrein;

namespace Circustrein.Tests
{
    [TestClass]
    public class TrainWagonTests
    {
        [TestMethod]
        public void Can_add_animal_to_trainWagon()
        {
            // Arrange
            TrainWagon w = new TrainWagon();
            bool Filled = false;

            // Act
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Large));
            
            if (w.getSize() != 0)
            {
                Filled = true;
            }

            // Assert
            Assert.IsTrue(Filled);
        }

        [TestMethod]
        public void Cant_have_2_carnivores_in_one_trainWagon()
        {
            // Arrange
            TrainWagon w = new TrainWagon();

            // Act
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Medium));

            // Assert
            Assert.AreEqual(false, w.AddAnimalIfSafe(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Medium), w));
        }

        [TestMethod]
        public void Cant_go_over_the_trainWagon_capacity()
        {
            // Arrange
            TrainWagon w = new TrainWagon();
            
            // Act
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Large));
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Medium));
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Small));

            // Assert
            Assert.AreEqual(false, w.EnoughCapacity(w.getSize(), (int)Animal.AnimalSize.Large, 10));
        }
    }
}
