using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOBShelter.Services;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create
            Person p1 = new Person(
                IdentityTitle.M,
                "BRUNGARD",
                "Luc",
                "17",
                RouteType.RUE,
                "des étangs",
                "57420",
                "Solgne");

            Person p2 = new Person(
                IdentityTitle.SOCIETE,
                "MASOCIETE",
                null,
                "17",
                RouteType.RUE,
                "des étangs",
                "57420",
                "Soglne");

            Console.WriteLine($"Create physical : {TOBShelter.Services.PersonService.Create(p1)}");
            Console.WriteLine($"Create societe : {TOBShelter.Services.PersonService.Create(p2)}");


            // Edit
            PersonDetailsDTO d1 = new PersonDetailsDTO { 
                Id = 1,
                City = "Metz"
            };
            PersonDetailsDTO d2 = new PersonDetailsDTO
            {
                Id = 2,
                City = "Metz"
            };

            Console.WriteLine($"Update physical : {TOBShelter.Services.PersonService.Update(d1)}");
            Console.WriteLine($"Update societe : {TOBShelter.Services.PersonService.Update(d2)}");

            // Find
            PersonDetailsDTO p = TOBShelter.Services.PersonService.FindById(1);
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Title);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.Mobile);
            Console.WriteLine(p.Home);
            Console.WriteLine(p.Email);
            Console.WriteLine(p.NumRoute);
            Console.WriteLine(p.RouteType);
            Console.WriteLine(p.RouteName);
            Console.WriteLine(p.PostalCode);
            Console.WriteLine(p.City);

            // FindAll
            PersonDetailsDTO filters = new PersonDetailsDTO
            {
                FirstName = "Luc"
            };

            Console.WriteLine("FindAll (no filters) :");
            List<PersonDTO> list = TOBShelter.Services.PersonService.FindAll(null);
            foreach (PersonDTO person in list)
            {
                Console.WriteLine(person.Id);
                Console.WriteLine(person.Title);
                Console.WriteLine(person.Name);
                Console.WriteLine(person.FirstName);
            }

            Console.WriteLine("FindAll (filters) :");
            list = TOBShelter.Services.PersonService.FindAll(filters);
            foreach (PersonDTO person in list)
            {
                Console.WriteLine(person.Id);
                Console.WriteLine(person.Title);
                Console.WriteLine(person.Name);
                Console.WriteLine(person.FirstName);
            }

            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
        }
    }
}
