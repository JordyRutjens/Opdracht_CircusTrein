using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_CircusTrein
{
    public partial class Form_Main : Form
    {
        private void Form_Main_Load(object sender, EventArgs e)
        {
            TrainWagon w = new TrainWagon();
            train.AddWagon(w);
        }

        Train train = new Train();
        public enum AnimalType
        {
            Meat,
            Plants
        };
        public enum AnimalSize
        {
            Small,
            Medium,
            Large
        };

        public AnimalType animalType;
        public AnimalSize animalSize;

        public Form_Main()
        {
            InitializeComponent();
            cmbAnimalSize.DataSource = Enum.GetValues(typeof(AnimalSize));
            cmbAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Enum.TryParse<AnimalType>(cmbAnimalType.SelectedValue.ToString(), out animalType);
            Enum.TryParse<AnimalSize>(cmbAnimalSize.SelectedValue.ToString(), out animalSize);
            Animal addedAnimal = new Animal(animalType, animalSize);
            train.AddAnimalsToWagon(addedAnimal);
            UpdateListBox();

            lsbAnimalsInQ.Items.Add($"Worth: {addedAnimal.PointsToAdd} Size: {addedAnimal.GetAnimalSize} Type: {addedAnimal.GetAnimalType}");
        }

        public void UpdateListBox()
        {
            lsbCurrentAnimals.Items.Clear();
            lsbTrainMain.Items.Clear();

            foreach (var item in train.AllWagons())
            {
                lsbTrainMain.Items.Add(item);
            }
        }

        private void lsbTrainMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbCurrentAnimals.Items.Clear();
            foreach (var item in train.GetWagonAnimals(lsbTrainMain.SelectedIndex))
            {
                lsbCurrentAnimals.Items.Add(item);
            }
        }
    }
}
