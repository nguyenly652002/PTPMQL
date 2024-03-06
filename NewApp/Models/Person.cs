namespace NewApp.Models
{
    public class Person
    {
       public string FullName { get; set;}
       public string Address { get; set;}
       public int Age { get ;set; }
       public void EnterData()
       public int GetYearOfBirth(int age)
       {
        System.Console.Write("FullName = ");
        FullName = Console.ReadLine();
        System.Console.Writr("Address = ");
        Address = Console.ReadLine();
         System.Console.Write("Age = " );
        Age = Convert.ToInt16(Console.ReadLine());
       }
            public Person()
        {
            FullName = "Ho ten mac dinh";
            Address = "Dia chi mac dinh";
            Age = 22;
        }
       public void Display()
       {
        System.Console.WriteLine("{0} - {1} - {2} tuoi"), FullName, Address, Age;
       }
    }
}