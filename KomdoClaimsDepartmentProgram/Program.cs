using KomodoClaimsDepartmentUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomdoClaimsDepartmentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            KomodoIClaimsDepartmentUI program = new KomodoIClaimsDepartmentUI();
            program.Run();

            Queue<ClaimProperties> queueClaimProperties = new Queue<ClaimProperties>();
            ClaimProperties.Enqueue(1);
            ClaimProperties.Enqueue(2); 
            ClaimProperties.Enqueue(3);
            ClaimProperties.Enqueue(4);

            ClaimProperties c1 = queueClaimProperties.Dequeue();
            Console.WriteLine(c1.ClaimID + " - " + c1.TypeOfClaim);
            Console.WriteLine("Total items in the Queue = " + queueClaimProperties.Count);

            foreach (ClaimProperties c in queueClaimProperties)
            {
                Console.WriteLine(c.ClaimID + " - " + c.TypeOfClaim);
                Console.WriteLine("Total items in the Queue = " + queueClaimProperties.Count);
            }





        }

        
    }
}
