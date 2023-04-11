namespace Encaptulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////1)===>properti usulu

            //Person person = new Person();
            //Console.WriteLine("adinizi daxil edin");
            //person.Name = Console.ReadLine();
            //Console.WriteLine(person.name);
            //Console.WriteLine("Soyadinizi daxil edin");
            //person.Surname = Console.ReadLine();
            //Console.WriteLine(person.Surname);
            //Console.WriteLine("yasinizi daxil edin");
            //person.age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(person.age);
            //Console.WriteLine("dogum gunuvuzu qeyd edin");
            //person.BirthDay = Console.ReadLine();
            //Console.WriteLine(person.BirthDay);


           ///// //Encaptulation 2)=====>
            Person person = new Person();
            person.SetName("s");
            string name = person.GetName();
            Console.WriteLine(name);
            person.surname = "melikov";
            Console.WriteLine(person.surname);
            person.SetAge(2);
            int age = person.GetAge();
            Console.WriteLine(age);
            person.BirthDay = "27 noyabr";
            Console.WriteLine(person.BirthDay);
        }
    }
}