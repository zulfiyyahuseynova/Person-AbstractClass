using System;

namespace PersonAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Zulfiyye","Huseynova",19,5,200);
            e1.CalculateSalary();
            Student s1 = new Student("Zulfiyye", "Huseynova", 19, 50, 50);
            s1.ExamResult();
        }
    }
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    class Employee : Person
    {
        public int SalaryOfHour { get; set; }
        public int WorkingHour { get; set; }

        public void CalculateSalary()
        {
            int result = SalaryOfHour * WorkingHour;
            if (result<250)
            {
                Console.WriteLine("Maas 250 manatdan az ola bilmez");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
           
        public Employee(string name, string surname, int age, int salaryOfHour, int workingHour)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SalaryOfHour = salaryOfHour;
            WorkingHour = workingHour;
            if (Age < 18)
            {
                Console.WriteLine("Sizin isleme huququnuz yoxdur");
            }
            if ((WorkingHour/30) > 8)
            {
                Console.WriteLine("Gundelik is saati 8 saatdan cox ola bilmez");
            }
        }

    }
    class Student : Person
    {
        public int IQRank { get; set; }
        public int LanguageRank { get; set; }
        public void ExamResult()
        {
            int result = IQRank + LanguageRank;
            if (IQRank < 0 || IQRank > 100 || LanguageRank < 0 || LanguageRank > 100)
            {
                Console.WriteLine("Melumatlar sehv daxil edilib");
            }
            else
            {
                if (result<120)
                {
                    Console.WriteLine("Imtahandan kesildiniz");
                }
                else
                {
                    Console.WriteLine("Imtahandan kecdiniz");
                }
            }
            
        }
        public Student(string name, string surname, int age, int iqRank, int languageRank)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IQRank = iqRank;
            LanguageRank = languageRank;
            if (Age<6 || Age>20)
            {
                Console.WriteLine("Telebenin yasi sehv daxil edilib");
            }
        }
    }
}
