using System;
namespace Asgmt;

public class Program {
    public static void Main(string[] args) {

        var program = new Program();
        var input = Console.ReadLine();
        var year = Int32.Parse(input);
        var leapYear = program.IsLeapYear(year);
        var yayornay = program.yayOrNay(leapYear);
        Console.WriteLine(yayornay);
    }

    public bool IsLeapYear(int year) {
        if (year % 4 == 0) {
            if (year % 100 == 0) {
                if (year % 400 == 0) return true;
                else return false;
            }
            else return true;
        }
        else return false;
    }

    public string yayOrNay(bool ans) {
        if (ans == true) return "yay";
        else return "nay";
    }
}