using System;
namespace Asgmt;

public class Program {
    public static void Main(string[] args) {

        var program = new Program();
        var input = Console.ReadLine();
        if (program.isErrorFree(input)) {
            var year = Int32.Parse(input);
            var leapYear = program.IsLeapYear(year);
            var yayornay = program.yayOrNay(leapYear);
            Console.WriteLine(yayornay);
        }
        else {
            Console.WriteLine(program.errorMessage(input));
        }
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

    public bool isErrorFree(string input) {
        try {
            var year = Int32.Parse(input);
            if (year < 1582) return false;
            return true;
        }
        catch (Exception) {
            return false;
        }
    }

    public string errorMessage(string input) {
        try {
            var year = Int32.Parse(input);
            if (year < 1582) return "The input is lower than 1582";
            return "There is some error";
        }
        catch (FormatException) {
            return "The input is not a number";
        }
         catch (OverflowException) {
            return "Overflow";
        }
    } 
}