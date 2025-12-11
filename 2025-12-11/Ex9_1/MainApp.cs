using System;

namespace Ex9_1
{
    class NameCard
    {
        private int age { get; set; }
        private string name { get; set; }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /*public int GetAge()
        { return age; }

        public void SetAge(int value)
        { age = value; }

        public string GetName() 
        { return name; }

        public void setName(string value) 
        { name = value; }*/
    }

    class MainApp
    {
        public static void Main()
        {
            NameCard MyCard = new NameCard()
            { Age = 24, Name = "인아" };

            Console.WriteLine("나이 : {0}", MyCard.Age);
            Console.WriteLine("이름 : {0}", MyCard.Name);
        }
    }
}