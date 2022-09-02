using System;

namespace Assignment0._2;
public class Program {
    public static void Main(string[] args) {

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
}
