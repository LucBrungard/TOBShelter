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
            bool res;
            // Create
            Identity identity = new Physical(IdentityTitle.M, "brungard", "Luc");
            Route route = new Route("17", RouteType.RUE, "des etangs");
            Coordinates coordinates = new Coordinates(null, null, null, route, "57420", "Solgne");
            Identity i2 = new Society(IdentityTitle.SOCIETE, "MaSociete");

            Console.WriteLine($"Create physical : {TOBShelter.Services.PersonService.Create(new Person(identity, coordinates))}");
            Console.WriteLine($"Create societe : {TOBShelter.Services.PersonService.Create(new Person(i2, coordinates))}");


            // Edit
            PersonEditDTO details = new PersonEditDTO();
            details.City = "Metz";

            Console.WriteLine($"Update physical : {TOBShelter.Services.PersonService.Update(identity, details)}");
            Console.WriteLine($"Update societe : {TOBShelter.Services.PersonService.Update(i2, details)}");

            // Find

            // FindAll
            PersonDetailsDTO personDetailsDTO = new PersonDetailsDTO();
            personDetailsDTO.FirstName = "Luc";

            Console.WriteLine("FindAll :");
            List<Identity> list = TOBShelter.Services.PersonService.FindAll(null);
            foreach (Identity id in list) {
                Console.WriteLine(id.Title);
                Console.WriteLine(id.Name);
                if (id is Physical p)
                    Console.WriteLine(p.FirstName);
            }

            Console.WriteLine("FindAll :");
            list = TOBShelter.Services.PersonService.FindAll(personDetailsDTO);
            foreach (Identity id in list)
            {
                Console.WriteLine(id.Title);
                Console.WriteLine(id.Name);
                if (id is Physical p)
                    Console.WriteLine(p.FirstName);
            }

            //Person person = TOBShelter.Services.PersonService.(IdentityTitle.M, "brungard", "Luc");
            //Console.WriteLine(person.Identity.Title);
            //Console.WriteLine(person.Identity.Name);
            //Console.WriteLine(person.Coordinates.Mobile);
            //Console.WriteLine(person.Coordinates.Home);
            //Console.WriteLine(person.Coordinates.Email);
            //Console.WriteLine(person.Coordinates.Route.Num);
            //Console.WriteLine(person.Coordinates.Route.Type);
            //Console.WriteLine(person.Coordinates.Route.Name);
            //Console.WriteLine(person.Coordinates.PostalCode);
            //Console.WriteLine(person.Coordinates.City);
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
        }
    }
}
