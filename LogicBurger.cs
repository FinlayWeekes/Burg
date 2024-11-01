using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Collections.ObjectModel;
using System.Resources;
using System.Net.Http.Headers;
using System.Diagnostics;

//Use     https://www.tutorialspoint.com/csharp/online-csharp-compiler.php    for compiling
//I does not use colour, would highly recomend running it youself in visual studio to use it
//Make sure to press enter on the same line as it asks at the start


//\u001b[0m- reset colour
//https://ansi.gabebanks.net/ -colour picker
//all colours start with \u001b

public class LogicBurger
{
    public static string person = "";
    public static string cashier = "\u001b[33mCashier-\u001b[0m";
    public static string god = "\u001b[33mGod- \u001b[0m";
    public static string judge = "\u001b[33mJudge-\u001b[0m";

    public static string endingAmmount = "23"; 
    public static string secretEndingAmmount = "5";
    public static bool flag = false;
    public static bool yes = false;
    public static bool no = false;
    public static string response = "";
    public static bool reset = false;
    public static bool rebel = true;

     
    public static void Templates()
    {
        //template for responding if statement:
        /*
        do
        {
            LogicBurger.flag = false;
            Console.WriteLine("[question here]");
            LogicBurger.Respond(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
            if(yes == true && reset == false)
            {
                
            }
            else if(no == true && reset == false)
            {
                
            }
            else if (reset == false)
            {
                Console.WriteLine("{0}What is bro waffling about, do that again", god);
                Console.ReadLine();
                LogicBurger.flag = true;
            }
            reset = true;
        }
        while(LogicBurger.flag == true);
        */

        //template for end line
        //Console.WriteLine("\u001b[35;1mEnding {0}/{1}: {2}\u001b[0m", Ending[1,0], LogicBurger.endingAmmount, Ending[0,0]);
        
    }

    public static void Intro()
    {
        Console.WriteLine("");
        Console.WriteLine("\u001b[34;4mBurger King Siulator\u001b[0m");
        Console.WriteLine("");
        Console.WriteLine("Type \u001b[32my\u001b[0m for \u001b[32mYes\u001b[0m, \u001b[31mn\u001b[0m for \u001b[31mNo\u001b[0m or anything else that might be relevant in responsces");
        Console.WriteLine("Type r to Reset");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }

    public static void Respond(ref bool yes, ref bool no, ref string response, ref string cashier, ref bool reset, ref string endingAmmount, string[,] Ending, ref bool flag, ref string god, ref string judge, ref bool rebel, string[,] SecretEnding, ref string secretEndingAmmount, ref string person)
    {
        yes = false;
        no = false;
        response = "";
        reset = false;
#pragma warning disable CS8601 // Possible null reference assignment.
        response = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
        

        if (response == "y" || response == "yes" || response == "Y" || response == "Yes")
        {
            yes = true;
            reset = false;
            Console.WriteLine("");
        }
        else if (response == "n" || response == "no" || response == "N" || response == "No" )
        {
            no = true;
            reset = false;
            Console.WriteLine("");
        }
        else if (response == "r" || response == "reset" || response == "R" || response == "Reset")
        {
            VarReset(ref yes, ref no, ref response, ref reset, ref cashier, ref god);
            reset = true;
            MainBurger.EnterBurgerKing(ref yes, ref no, ref response, ref cashier, ref reset, ref endingAmmount, Ending, ref flag, ref god, ref judge, ref rebel, SecretEnding, ref secretEndingAmmount, ref person);
        }
    }

    public static void VarReset(ref bool yes, ref bool no, ref string response, ref bool reset, ref string chashire, ref string god)
    {
        yes = false;
        no = false;
        response = "";
        reset = false;
        cashier = "\u001b[33mCashier-\u001b[0m";
        god = "\u001b[33mGod-\u001b[0m";
        rebel = true;
    }
}
