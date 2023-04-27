using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TOBShelter.Services;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    public partial class AddAnimal : Form
    {
        private Dictionary<string, long> dic = new Dictionary<string, long>();
        public Animal animal = null;

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
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string breedTypeName = this.cmbBreed.SelectedItem.ToString();
                    Type breedType = AppDomain.CurrentDomain.GetAssemblies().SelectMany(t => t.GetTypes()).Where(t => String.Equals(t.Name, breedTypeName, StringComparison.Ordinal)).First();
                    Breed breed = (Breed)Activator.CreateInstance(breedType);

                    string animalTypeName = this.cmbType.SelectedItem.ToString();
                    Type animalType = AppDomain.CurrentDomain.GetAssemblies().SelectMany(t => t.GetTypes()).Where(t => String.Equals(t.Name, animalTypeName, StringComparison.Ordinal)).First();
                    this.animal = (Animal)Activator.CreateInstance(animalType, new object[6] {
                this.txtName.Text,
                Convert.ToUInt32(this.nudAge.Value),
                this.txtWeight.Text,
                (Gender)this.cmbSexe.SelectedItem,
                breed,
                this.dic[cmbOwner.SelectedItem.ToString()]
                });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Impossible d'ajouter un animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AnimalService.Create(this.animal);
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible d'ajouter un animal pour le moment", "Impossible d'ajouter un animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string animalTypeName = (sender as ComboBox).SelectedItem.ToString();
            Type animalType = AppDomain.CurrentDomain.GetAssemblies().SelectMany(t => t.GetTypes()).Where(t => String.Equals(t.FullName, "TOBShelter.Types.Base.Breed+" + animalTypeName, StringComparison.Ordinal)).First();
            IEnumerable<Type> races = animalType.Assembly.GetTypes().Where(type => type.IsSubclassOf(animalType));

            this.cmbBreed.Items.Clear();
            foreach (Type race in races)
            {
                cmbBreed.Items.Add(race.Name);
            }
        }
    }
}