using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOBShelter.Services;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Composed.Animals;
using TOBShelter.Types.Dto;
using static TOBShelter.Types.Base.Breed.Cat;

namespace TOBShelter
{
    public partial class AddAnimal : Form
    {
        Dictionary<string, long> dic = new Dictionary<string, long>();

        public AddAnimal()
        {
            InitializeComponent();

            List<PersonDTO> listPerson = PersonService.FindAll(null);

            foreach (PersonDTO person in listPerson)
            {
                string str = person.FirstName + " " + person.Name;
                if (!dic.ContainsKey(str))
                {
                    this.dic.Add(str, person.Id);
                    this.cmbOwner.Items.Add(str);
                }
            }

            this.cmbSexe.DataSource = Enum.GetValues(typeof(Gender));

            this.cmbType.Items.Add("Cat");
            this.cmbType.Items.Add("Dog");
            this.cmbType.Items.Add("Horse");

            this.cmbBreed.Items.Add("ABYSSIN");
            this.cmbBreed.Items.Add("AMERICAN_CURL");
            this.cmbBreed.Items.Add("AMERICAN_SHORTHAIR");
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                string breedTypeName = "TOBShelter.Types.Base.Breed+Cat+" + this.cmbBreed.SelectedItem.ToString();
                Type breedType = Type.GetType(breedTypeName);
                ConstructorInfo constructBreed = breedType.GetConstructor(Type.EmptyTypes);
                Breed breed = (Breed)constructBreed.Invoke(new object[] { });

                string animalTypeName = "TOBShelter.Types.Base.Breed+" + this.cmbType.SelectedItem.ToString();
                Type animalType = Type.GetType(animalTypeName);

                ConstructorInfo constructAnimal = animalType.GetConstructor(new[] { 
                    typeof(string), 
                    typeof(uint), 
                    typeof(string), 
                    typeof(Gender), 
                    typeof(Breed), 
                    typeof(long) 
                });
                Animal animal = (Animal)constructAnimal.Invoke(new object[] {
                    this.txtName.Text.Trim(),
                    Convert.ToUInt32(this.nudAge.Value),
                    this.txtWeight.Text.Trim(),
                    (Gender)this.cmbSexe.SelectedItem,
                    breed,
                    this.dic[cmbOwner.SelectedItem.ToString()]
                });

            /*}
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible d'ajouter un animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
