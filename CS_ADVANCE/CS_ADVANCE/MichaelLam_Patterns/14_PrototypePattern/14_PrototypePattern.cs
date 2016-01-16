using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._14_PrototypePattern
{
    public static class _14_PrototypePattern
    {
        public static void Caller()
        {
            XBoxGame xg = new Halo("Halo 4") { ProducKey = "00000-00000-00000-00000" }; //OrginalCopy 
            XBoxGame gameCopy;

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                gameCopy = xg.Clone();
                gameCopy.ProducKey = XBoxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title: {0} Product Key: {1}",gameCopy.Title,gameCopy.ProducKey);
            }
            Console.ReadKey();
        }
    }
}
