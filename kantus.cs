using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace kantus 
{
    public static class Kantus
    {
        static void Main()
        {

            //Brief explaining of Loops & Strings

            string fName = "Bantu";
            string mName = "Neil";
            string lName = "Hanther";
            //string[] name0 = {"Bantu", "Neil", "Hanther"}; Full Name Code
            int age = 33;
            
            string fName0 ="Raji";
            string mName0 = "Neil";
            string lName0 = "Hanther";
            //string[] name1 = {"Raji" , "Neil" , "Hanther"}
            int age0 = 30;

            Console.WriteLine(fName0 + " " + mName0 + " " + lName0 + " " + age0);
            Console.WriteLine(fName + " " + mName + " " + lName + " " + age);

            double money = 4.50d; //it will hold a certain size of value
            double price = 0.25d; //

            //decimal money = 4.50m; //
            //decimal price = 0.25m; //
            string item = "Gum"; //
            string place = "Store";

            Console.WriteLine("$" + money + " " + item + " " + place);

            //TODO: Create & Understand Engine. More do while loops.
            //money half of money / 2  Example (money <= money / 2);
            do{
                
                Console.WriteLine(fName + " Went to the " + place + " and spent $" + price + " on " + item);
                money = money - price;
            }while(money <= money / 2);
        }
    }
}