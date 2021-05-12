using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            //RECTOR
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Tax=0.25;

            //VICERECTOR FINANCIER0
            Position vicefinanPosition = new Position();
            vicefinanPosition.Name = "Vicerector Financiero";
            vicefinanPosition.Salary = 750;
            vicefinanPosition.Tax = 0.20;

            //CONTADOR
            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            contadorPosition.Tax = 0.30;

            //JEFE FINANCIERO
            Position jefeFinanPosition = new Position();
            jefeFinanPosition.Name = "Jefe Financiero";
            jefeFinanPosition.Salary = 610;
            jefeFinanPosition.Tax = 0.15;

            //SECRETARIA FINANCIERA 1
            Position secreFin1Position = new Position();
            secreFin1Position.Name = "Secretaria Financiera 1";
            secreFin1Position.Salary = 350;
            secreFin1Position.Tax = 0.02;

            //SECRETARIA FINANCIERA 2
            Position secreFin2Position = new Position();
            secreFin2Position.Name = "Secretaria Financiera 2";
            secreFin2Position.Salary = 310;
            secreFin2Position.Tax = 0.02;

            //VICERECTOR ACADEMICO
            Position viceacadPosition = new Position();
            viceacadPosition.Name = "Vicerector Académico";
            viceacadPosition.Salary = 780;
            viceacadPosition.Tax = 0.25;

            //JEFE DE REGISTRO
            Position jefeRegisPosition = new Position();
            jefeRegisPosition.Name = "Jefe Registro";
            jefeRegisPosition.Salary = 640;
            jefeRegisPosition.Tax = 0.12;

            //SECRETARIA DE REGISTRO 2
            Position secRegis2Position = new Position();
            secRegis2Position.Name = "Secretaria de Registro 2";
            secRegis2Position.Salary = 360;
            secRegis2Position.Tax = 0.02;

            //SECRETARIA DE REGISTRO 1
            Position secRegis1Position = new Position();
            secRegis1Position.Name = "Secretaria de Registro 1";
            secRegis1Position.Salary = 400;
            secRegis1Position.Tax = 0.02;

            //ASISTENTE 2
            Position asis2Position = new Position();
            asis2Position.Name = "Asistente 2";
            asis2Position.Salary = 170;
            asis2Position.Tax = 0.00;

            //ASISTENTE 1
            Position asis1Position = new Position();
            asis1Position.Name = "Asistente 1";
            asis1Position.Salary = 250;
            asis1Position.Tax = 0.00;

            //MENSAJERO
            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.Tax = 0.00;

            
            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicefinanPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicefinanPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinanPosition, vicefinanPosition.Name);

            universityTree.CreatePosition(universityTree.Root, viceacadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegisPosition, viceacadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secRegis2Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secRegis1Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asis2Position, secRegis1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asis2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asis1Position, secRegis1Position.Name);

            universityTree.PrintTree(universityTree.Root);

            //SUMATORIA DE TODOS LOS SALARIOS DEL ARBOL
            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total Salaries: {totalSalary}");

            //Console.ReadLine();

            //Get the longest salary (without including "the principal". Point 1
            float longestSalary = universityTree.longestSalary(universityTree.Root);
            Console.WriteLine($"the longest salary is: {longestSalary}");

            //Average Salaries. Point 2
            float averageSalaries = universityTree.averageSalaries(universityTree.Root);
            Console.WriteLine($"Average Salaries: {averageSalaries}");

            //How much is the salary given a certain position, Point 3
            Console.Write("Insert Name: ");
            string nametemp= Console.ReadLine();
            float salaryEmployee = universityTree.salaryEmployee(universityTree.Root,nametemp);
            Console.WriteLine($"the salary of {nametemp} is: {salaryEmployee}");

            //Add salary tax (percentaje 0%-30%), each position has a different tax percentaje, Point 4
            float taxSalary = universityTree.taxSalary(universityTree.Root);
            Console.WriteLine($"the sumatory tax is {taxSalary}");
        }
    }
}
