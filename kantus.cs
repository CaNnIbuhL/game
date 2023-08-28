using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace kantus //a namespace - used for organization
{
    public static class Kantus //a class - has members (such as a method)
    {
        static void Main() //a method - contaains a block of code. Where your program starts.
        {
            System.Console.WriteLine(); //fully qualified name
            Console.WriteLine("Gold World!"); //a statement

            //Computer Science

            //Structure = namespace -> classes -> members -> method -> statements
            //create the method
            //invoke the method
            //variable - stores some value
            //identifier - what we call the variable
            //expression - evaluates to a value
            //oerator - it works on operands
            //operand - the thing(s) that the operator works on
            //literal - actual value

            /* creating a variable 'data type' int . identifier 'x' .
            Assignment operator '=' . a value '5' . 
            int x = 5; - declaration initialization */
            //int y; //declaration
            //y = 5; //initialization

            //Comparison operators True/False
            Console.WriteLine(1 > 2); 
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            //Conditional operator
            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {discount}");

            //Conditional operator inline
            int saleAmount0 = 1001;
            //int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {(saleAmount0 > 1000 ? 100 : 50)}");

            //Data Types
            int a = -7;
            uint b = 7;
            char c = 'C';
            float d = 4.4f;
            double e = 4.4d;
            decimal f = 4.4m;
            bool g = true;
            string h = "Hello";

            Console.WriteLine(a + "" + b + "" + c +"" + 
            d +"" + e +""+ f +""+ g +""+ h);

            int farm = 8;
            int lake = farm;

            Console.WriteLine(farm);
            Console.WriteLine(lake);

            lake = 70;

            Console.WriteLine(farm);
            Console.WriteLine(lake);


            /* Combine operands w/operators inside of a expression 
            to evaluate a value */
            //example 
            /* string x = "Mission";
               Console.WriteLine(x + "complete"); */ 
               //Concatenation (x + "complete");


            //Brief explaining of Loops & Strings 


            //string name = "life";
            //Console.WriteLine("Hello" + name + "!"); //option 1
            //Console.WriteLine($"Hello {name}!"); //option 2

             

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
            //decimal price = 0.25m; 
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