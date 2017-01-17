using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To being your fortune telling session please follow the instructions below.");
            Console.WriteLine("You may type \"Quit\" or \"Restart\" at any time. \n Press enter to begin!");
            string quitRestartInput = Console.ReadLine().ToUpper();
            string quitRestartCaps = quitRestartInput.ToUpper();

            Console.WriteLine("Enter your first name.");
            string firstName = Console.ReadLine();
            QuitRestart(firstName); //quit restart method

            Console.WriteLine("Thank you " + firstName + ". Next please enter your last name.");
            string lastName = Console.ReadLine();
            QuitRestart(lastName); //quit restart method


            //related to greetings method 
            Console.WriteLine(UserName(firstName, lastName));
            QuitRestart(UserName(firstName, lastName)); //quit restart method


            //related to retires method
            Console.WriteLine("Please enter your age");
            string ageQuitRestart = Console.ReadLine();
            QuitRestart(ageQuitRestart); //quit restart method
            int age = int.Parse(ageQuitRestart);
            int retireYears = RetireAge(age);
            

            //related to money when retire method
            Console.WriteLine("Now that I know your age, please enter your birth month (digits only).");
            string monthQuitRestart = Console.ReadLine();
            QuitRestart(monthQuitRestart); //quit restart method because int
            int birthMonth = int.Parse(monthQuitRestart);
            

            //related to transport method
            Console.WriteLine("To contiue with your fortune reader, what is your favorite ROYGBIV color?" + "\n" + "Please enter \"help\" for description of ROYGBIV.");
            string response = Console.ReadLine();
            string responseCaps = response.ToUpper();
            QuitRestart(responseCaps);
            if (responseCaps == "HELP")
            {
                Console.WriteLine("ROYGBIV COLORS: \nR is for Red. \nO is for Orange. \nY is for Yellow. \nG is for Green. \nB is for Blue. \nI is for Indigo. \nV is for Violet. \nEnter a ROYGBIV color: ");
                response = Console.ReadLine();
                responseCaps = response.ToUpper();
                QuitRestart(responseCaps);
            }
            else
            {
                Console.WriteLine("That is an invalid response, you get a squeaky shopping cart!");
            }
        

            //related to vacation home method
            Console.WriteLine("Enter the number of sibilings that you have.");
            string sibilingQuitRestart = Console.ReadLine();
            QuitRestart(sibilingQuitRestart);
            int siblings = int.Parse(sibilingQuitRestart);
            

            //starting the fortune response.
            Console.WriteLine(firstName + " " + lastName +"," + " you will retire in " + retireYears + " years. " + "You will have $" + RetirementBankAccount(birthMonth) + " in the bank! (How exciting is that?)" + " You will also have " + VacationHome(siblings)+ "." + " In addition to all that awesomeness, you will also own " + TransportMode(responseCaps) + ".");
            FortuneQuality();
        }
        

        //start bulding methods here
        //method for greeting
        static string UserName(string firstName, string lastName)
        {
            String greeting = "Greetings, " + firstName + " " + lastName +". I will tell you your fortune!";
            return greeting;
        }

        //method for years before retirement 
        static int RetireAge(int age)
        {
            int retireYears = 0;

            if (age % 2 == 0)  //figure out if the age is even or odd
            {
                retireYears = 22; //even number
            }
            else
            {
                retireYears = 35;
            }
            return retireYears;
        }

        //method for vacation home
        static string VacationHome(int siblings)
        {
            string userVaca = "";

            if (siblings == 0)
            {
                userVaca = ("a beach house in Cancun");
            }

            else if (siblings == 1)
            {
                userVaca = ("a vacation home in Colorado");
            }
            else if (siblings == 2)
            {
                userVaca = ("a vacation home in Spain");
            }
            else if (siblings == 3)
            {
                userVaca = ("a beach house in Croatia");
            }
            else if (siblings > 3)
            {
                userVaca = ("a beach house in Australia");
            }
            else
            {
                userVaca = ("a trailer in Crappy Ohio");
            }
            return userVaca;
        }

        //method for transportation - ROYGBIV
        static string TransportMode (string responseCaps)
        {
            string userTransport = "";

            switch (responseCaps)
            {
                case "RED":
                    userTransport = ("a boat");
                    break;
                case "ORANGE":
                    userTransport = ("a Ford SUV");
                    break;
                case "YELLOW":
                    userTransport = ("a motorcycle");
                    break;
                case "GREEN":
                    userTransport = ("a Rolls Royce");
                    break;
                case "BLUE":
                    userTransport = ("a bike");
                    break;
                case "INDIGO":
                    userTransport = ("a yacht");
                    break;
                case "VIOLET":
                    userTransport = ("an airplane");
                    break;
                default:
                    userTransport = ("a squeaky shopping cart");
                    break;    
        }
        return userTransport;
        }    


        //method for money when retire
        static double RetirementBankAccount (int birthMonth)
        {
            double money;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = 3.45d;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = 4.6d;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = 500.56d;
            }
            else
            {
                money = 0.0d;
            }
            return money;
        }

        //method for quit or restart
        static void QuitRestart(string quitRestartInput)
        {
            string quitRestartCaps = quitRestartInput.ToUpper(); 
            if (quitRestartCaps == "QUIT")
            {
                Console.WriteLine("Thank you for playing.");
                Environment.Exit(0);
            }
            else if (quitRestartCaps == "RESTART")
            {
                Console.WriteLine("Restarting now...");
                string[] args = { };
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }
        
        }

        //method that judges fortune
        static void FortuneQuality()
        {
            string response = "Your fortune rocks!";
            Console.WriteLine(response);
        }

    }
}
