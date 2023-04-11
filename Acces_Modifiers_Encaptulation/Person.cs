
namespace Encaptulation
{
    internal class Person

    {
        /////properti methodu
        //private string _name;
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (value.Length <= 2)
        //        {
        //            Console.WriteLine("Adivizi duzgun qeyd edin!");
        //            return;
        //        }
        //        _name = value;
        //        return;

        //    }
        //}
        //private string _surname;
        //public string Surname
        //{
        //    get { return _surname; }
        //    set
        //    {
        //        _surname = value;
        //    }
        //}


        //private int _age;
        //public int Age
        //{
        //    set
        //    {
        //        if (age < 16)
        //        {
        //            Console.WriteLine("Yashiniz balacadir.");
        //            return;
        //        }

        //    }
        //    get
        //    {
        //        return _age;
        //    }

        //}
        //private string _birthday;
        //public string Birthday
        //{
        //    get
        //    {
        //        return _birthday;
        //    }
        //    set
        //    {
        //        _birthday = value;
        //        return;
        //    }
        //}


        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string BirthDay { get; set; }




        ///Encaptulation 
        private string _name;
        public void SetName(string value)
        {
            if (value.Length > 2)
            {
                _name = value;
                return;
            }
            else
            {
                Console.WriteLine("adinizi duzgun daxil edin");
            }
        }
        public string GetName()
        {
            return _name;
        }


        private int _age;
        public void SetAge(int value)
        {
            if (value > 16)
            {

                _age = value;
                return;
              
            }
            else
            {
                Console.WriteLine("yasiniz catmir!");

            }
        }
        public int GetAge()
        {
            return _age;
        }


    }


}
