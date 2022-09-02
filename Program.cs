using System;
public class program
{
    public static void Main()
    {
        string Upper = Upper_point();
        string Lower = Down_point();
        string Number = Num_use();
        double Number_Changer_Upper = ConvertToDouble(Upper);
        double Number_Changer_Lower = ConvertToDouble(Lower);
        double Number_Changer_Number = ConvertToDouble(Number);
        Console.WriteLine(Logic(Number_Changer_Upper,Number_Changer_Number,Number_Changer_Lower));
    




    }
    public static string Upper_point()
    {
        Console.Write("Pls input your upper :");
        return Console.ReadLine();
    }
    public static string Down_point()
    {
        Console.Write("Pls input your Lower :");
        return Console.ReadLine();
    }
    public static string Num_use()
    {
        Console.Write("Pls input your number : ");
        return Console.ReadLine();
    }
    public static double ConvertToDouble(string input)
    {
        if(double.TryParse(input,out double change))
        {
            return change;
        }
        throw new Exception("Pls input again");
    }
    public static string Logic(double upper,double x , double lower)
    {
        if(IsTrue(upper,x,lower))
        {
          return "True" ;
        }
        else if(IsFalse(upper,x,lower))
        {
            return "False";
        }
        else return "Stop";
    }
    public static bool IsFalse(double upper,double x , double lower)
    {
        return x>upper||x<lower;
    }
     public static bool IsTrue(double upper,double x , double lower)
    {
        return x>= lower && x <=upper;
    }
   
}
