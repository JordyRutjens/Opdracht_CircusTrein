using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Opdracht_CircusTrein;


namespace Circustrein.Tests
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void Can_Add_Animal_To_TrainWagon()
        {
            // Arrange
            Train train = new Train();
            int expected = 4;

            // Act
            for (int i = 0; i < 4; i++)
            {
                train.AddWagon(new TrainWagon());
            }

            List<TrainWagon> wlist = train.AllWagons();
            
            // Assert
            Assert.AreEqual(expected, wlist.Count);
        }

        [TestMethod]
        public void Get_All_Animals_In_TrainWagon()
        {
            // Arrange
            Train train = new Train();
            int expected = 3;

            //Act
            for (int i = 0; i < 3; i++)
            {
                train.AddAnimalsToWagon(new Animal(Animal.AnimalType.Plants, Animal.AnimalSize.Medium));
            }
            train.AddAnimalsToWagon(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Large));
            List<Animal> alist = train.GetWagonAnimals(0);
            int actual = alist.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
