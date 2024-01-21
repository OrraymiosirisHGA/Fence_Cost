using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fence_Cost
{
    class Fence
    {
        public static void Cost_Fence()
        {
            int select = 0;
            int wood = 25;
            int chlink = 15;
            int gates = 150;
            int gnumber = 0;
            float tax = 0.06F; // This doesn't apply to the bldg permit.
            float per = 0;
            float perchk = 0;
            float total = 0;
            float totalf = 0;
            int totalg = 0;
            int permit = 50;
            float totaltax = 0;

            Console.WriteLine("................................................Fence Cost Calculator App.............................................");
            Console.WriteLine("\nPlease Select the fencing type:");
            do
            {
                try // It is used to catch errors or exceptions;  
                {   //display a error message if the user do not enter one number from the menu.
                    //Console.Clear();
                    Console.WriteLine("[1]. Wooden fencing costs $25 per foot.");
                    Console.WriteLine("[2]. Chain Link fencing costs $15 per foot");

                    select = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("This is the wrong entrance please choose between [1 or 2].");
                }
            } while (!(select == 1) && !(select == 2));  // Loop that reapeat if  the user do not place the right fence type.

            if (select == 1) //In case the user select a wooden fence.
            {
                do {
                    try
                    {
                        Console.WriteLine("Please enter the perimeter of the yard in feet:");
                        per = float.Parse(Console.ReadLine());
                        perchk = per / per;//Every number divided by itself is 1. So, it makes sure the user is enntering a number.
                    }
                    catch
                       {
                        Console.Clear();
                        Console.WriteLine("Please enter perimeter of the area:");

                    }
                   } while (!(perchk == 1));


                Console.WriteLine("How many gates do you need?");
                Console.WriteLine("Note:The cost of the gates will $150.00 each one.");
                do
                {
                    try // It is used to catch errors or exceptions;  
                    {   //display a error message if the user do not enter one number from the menu.
                        //Console.Clear();
                        Console.WriteLine("You will need at least one gate, and no more than 3.");
                        Console.WriteLine("Please choose how many? [1][2][3]");
                      

                        gnumber = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("This is the wrong entrance, please choose between [1 to 3], you must need at least 1 gate" );
                    }
                } while (!(gnumber == 1) && !(gnumber == 2) && !(gnumber == 3));  // Loops until the user enter the right amount of gates.
                totalf =  per * wood;//Calcuate the total cost of the fence without the gates, tax and permit.
                totalg = gnumber * gates;//Give you the total price for the gates.
                totaltax = (totalf + totalg) * tax;//Calculate the tax value of the fence and gates.
                total = totalf + totalg + totaltax + permit;//Calulate the gates value, taxes, fence and permit. It will be the total value for the fence.

                Console.WriteLine("................................................Woden Fence...................................................");
                Console.WriteLine("The total of your Wooden Fence will be:");
                Console.WriteLine(per + " of Wooden Fence at $25.00 per foot = $" + totalf);
                Console.WriteLine(gnumber + " of gates at $150.00 each is: = $" + totalg);
                Console.WriteLine("6% TAX: $" + totaltax);
                Console.WriteLine("The city permit will be: $" + permit);
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("The Final amount to pay for your Wooden Fence Will be: $" + total);

            }
            else if (select == 2)//In case the user select a Chain Link fence.
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Please enter the perimeter of the yard in feet:");
                        per = float.Parse(Console.ReadLine());
                        perchk = per / per;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter perimeter of the area:");

                    }
                } while (!(perchk == 1));


                Console.WriteLine("How many gates do you need?");
                Console.WriteLine("Note:The cost of the gates will $150.00 each one.");

                do
                {
                    try // It is used to catch errors or exceptions;  
                    {   //display a error message if the user do not enter one number from the menu.
                        //Console.Clear();
                        Console.WriteLine("You will need at least one and no more than 3.");
                        Console.WriteLine("Please choose how many? [1][2][3]");

                        gnumber = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("This is the wrong entrance, please choose between [1 to 3], you must need at least 1 gate");
                    }
                } while (!(gnumber == 1) && !(gnumber == 2) && !(gnumber == 3));  // Loop that reapeat if  the user do not place the right fence type.
                
                totalf = per * chlink;
                totalg = gnumber * gates;
                totaltax = (totalf + totalg) * tax;
                total = totalf + totalg + totaltax + permit;

                Console.WriteLine("................................................Chain Link Fence.................................................");
                Console.WriteLine("The total of your Chain Link Fence will be:");
                Console.WriteLine(per + " of Wooden Fence at $15.00 per foot = $" + totalf);
                Console.WriteLine(gnumber + " of gates at $150.00 each is: = $" + totalg);
                Console.WriteLine("6% TAX: $" + totaltax);
                Console.WriteLine("The city permit will be: $" + permit);
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("The Final amount to pay for your Chain Link Fence Will be: $" + total);

            }
        }
    }
}
