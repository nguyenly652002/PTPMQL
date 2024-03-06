using NewApp.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Person ps1 = new Person ();
            Person ps2 = new Person ();
            ps1.FullName = "Nguyễn Thị Khánh Ly";
            ps1. Address = "Hà Nam";
            ps1.Age = 22;
            ps1.Display();
            ps2.Display();
        }
    }