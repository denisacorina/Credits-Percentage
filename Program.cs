using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Students
{
    public void info()
    {
        string name;
        int age;
        double eng, math, chi, obt_credits, total_credits = 180, per;
        Console.WriteLine("Enter Student Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter Student Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Marks of English: ");
        eng = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Marks of Math: ");
        math = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Student Science: ");
        chi = Convert.ToDouble(Console.ReadLine());
        obt_credits = eng + math + chi;
        per = (obt_credits / total_credits) * 100;
        Console.WriteLine("\n\n");
        Console.WriteLine("Name of Student is: {0}", name);
        Console.WriteLine("Student Age is : {0}", age);
        Console.WriteLine("Obtained Marks : {0}", obt_credits);
        Console.WriteLine("Percentage : {0}", per);
    }
}
class Program
{
    static void Main()
    {
        Students st = new Students();
        st.info();
        Console.ReadKey();
    }
}
