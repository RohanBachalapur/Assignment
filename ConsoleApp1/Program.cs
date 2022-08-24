// See https://aka.ms/new-console-template for more information
class MyClass
{
    enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns based on mark
    /// </summary>
    /// <param name="mark">mark as input</param>
    /// <returns></returns>
    public static string GetGrade(int mark)
    {
        if (mark >= (int)Grade.Distinction)
        {
            return "Distinction";

        }
        else if (mark >= (int)Grade.Pass)
        {
           return  "Pass";

        }
        else
        {
            return "Fail";
        }
    }
    public static void Main()
    {
        int empid;
        int mark;

        Console.WriteLine("Enter your ID");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine($"Thanks for giving your ID {empid}");



        Console.WriteLine("Enter your marks");
        mark = int.Parse(Console.ReadLine());
        string grade = GetGrade(mark);
        Console.WriteLine($"You are in {grade} grade");
    }
}