using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


//  Ish Elani layihesi

//  Sistemi 2 hissede ibaretdir
//	Worker(Ishchi)
//  Employer(Ishe Goturen)

//Bu projectde olacaqlarin mueyyen qismini yazmisham , size dersde basha saldigim sheylerin her biri olmalidir
////notification system, butun melumatlarin .json fayla yazilmagi, filter system
////(axtarish zamani her iki terefde(worker ve employer))
////butun project exceptionlari handle olunsun
////FILE system i, butun melumatlar, fayla yazilsin
////Systemde bash veren her  proses log.json faylina yazilsin
////Project chokmemelidir











namespace Project
{

    //Worker (class)
    //id
    //name
    //surname
    //Sheher
    //Phone
    //Age
    //CV(elave CV ler ola biler)

    class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Vacancies { get; set; }

        public Worker()
        {

        }
        public void Show()
        {
            Console.WriteLine($@"=====Worker=====
                                                   ");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Vacancies: {Vacancies}");

        }
    }


    //CV
    //Ixtisas
    //Oxudugu mekteb
    //Uni qebul bali
    //Bacariqlari(Skills(meselen:C#,C++,Java ve s.))
    //Companies(ishlediyi yerler)
    //Umumi ishe bashlama tarixi bitirme tarixi
    //Bildiyi xarici diller(Language(hansi dil, hansi seviyyede bilir))
    //Ferqlenme Diplomu var ya yox
    //GITLINK
    //LINKEDIN


    class CV
    {

    }


    //Employer

    //id
    //name
    //surname
    //Sheher
    //Phone
    //Age
    //Vacancies
    class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; } 
        public string Phone { get; set; }
        public string City { get; set; }
        public string Vacancies { get; set; }

        public Employer()
        {

        }
        public void Show()
        {
            Console.WriteLine($@"=====Employer=====
        ");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Vacancies: {Vacancies}");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            //Ilk olaraq sistemde username, password sorushsun
            //Hemin o userin Worker ve ya Employer olduguna esasen ekran achilsin.
            string username, password;
            int ctr = 0;
        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Default user name and password is :Shabnam and 123\n");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "Shabnam" || password != "123")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "Shabnam" || password != "123") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");
        }
    }
}
