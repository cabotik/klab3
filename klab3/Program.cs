using System;

namespace klab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("О сотруднике ");
            Employee еmployee = new Employee("ООО", "ГарантЛизинг", "Бухгалтер", "Горьева Анастасия Викторовна", 15);
            Console.WriteLine(еmployee.Print());

            Employee еmployee1 = new Employee("ИП", "N.Bar", "Бармен", "Мирова Алена Юрьевна", 2);
            Console.WriteLine(еmployee1.Print());
            Console.ReadLine();
        }
    }
}
