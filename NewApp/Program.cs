using System.ComponentModel.Design.Serialization;
﻿using System.Collections.Specialized;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Student ps = new Student();
            string str = "Nguyễn Thị Khánh Ly";
            int b = 22;
            string str = "Hà Nam";
            Console.WriteLine("{0} - {1} - {2}",str , ps.GetYearOfBirth(b) ,str );
        }
            Employee std = new Employee();
        std.EnterData();
        std.Display();
        }
    }