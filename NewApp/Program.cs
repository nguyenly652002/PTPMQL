// See https://aka.ms/new-console-template for more information
internal class Program
{
    private  static void Main(string[] args)
    {
        Console.Write("6");
        int a = 9;
        System.Console.WriteLine(" a = " + a);
        int b = 9;
        int c = 3;
        System.Console.WriteLine("{0} + {1} = {2}", b, c, b+c);

        //khai bao bien kieu string và gan gia tri = Nguyen Thi Khanh Ly
        string hoTen = "Nguyen Thi Khanh Ly";
        //khai bao bien kieu int va gan gia tri = 22
        int tuoi = 22;
        Console.WriteLine("Sinh viên {0} - {1} tuổi", hoTen, tuoi);

        //khai bao bien kieu string va gan gia tri = Nguyen Thi Khanh Ly
        const string hovaTen = "Nguyen Thi Khanh Ly";
        //khai bao bien kieu int va gan gia tri = 5
        const int namHoc = 5;
        Console.WriteLine("Sinh viên {0} - {1} năm ra trường", hovaTen, namHoc);
    }
}