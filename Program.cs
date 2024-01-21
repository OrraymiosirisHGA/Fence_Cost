using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Developer: Orraymiosiris H. Guevara.
 * C# Visual Studio Console  Cost of a Fence Project.
 * Description: The program will calculate the cost with tax of fencing a rectangular yard. 
 * The cost of the fencing will depend on the amount of fencing required (the perimeter of the yard), 
 * and the type of fencing used. Gates can are available for an additional cost.At least one gate is required.
 * Prices (including installation):
Wooden fencing costs $25 per foot
Chain-link fencing costs $15 per foot
Gates cost $150 each. You must install at least one gate and can install up to 3
A building permit is required. It costs $50.00.
The tax rate is 6.0% but it doesn't apply to the building permit
*/

namespace Fence_Cost
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] exit = {'y', 'n'};
            char q = exit[0];
            
            Fence.Cost_Fence();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Thank your for choosing our services!");
            Console.WriteLine("Do you want to continue with another Fencing Quote!");
            Console.WriteLine("Please Type [y] or [n].");
            q = char.Parse(Console.ReadLine());


            if (q == exit[1]) {
                Console.WriteLine("Thank you for being an amazing user! CHAO!");
                Console.ReadKey(true);

            }
            else if (q == exit[0]) {
                Console.Clear();
                Fence.Cost_Fence();
                Console.ReadKey(true);
            }
            else if (!(q == exit[0]) && !(q == exit[1]))
            {
                Console.WriteLine("This is the wrong entry. Thank you for being an amazing user! chao!!!");
                Console.ReadKey(true);
            }
        }
    }
}
