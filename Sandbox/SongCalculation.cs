using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class SongCalculation
    {
         public static double songTax(double songPrice)
         {
             return songPrice * 0.25;
         }
        /// <summary>
        /// Hvis der bestillet mere end 5 gives der 5 % rabat
        //  Hvis der bestilles mere end 10 gives der 12 % rabat
        //  Hvis der bestilles mere 20 gives der 50% rabat
        /// </summary>
        /// <param name="songPrice"> pricen </param>
        /// <param name="amount">Antal eksemplarer af sangen der er bestilt</param>
        /// <returns>Den beregnede rabat</returns>
        public static double SongAmountDiscount(double songPrice, int amount)
        {
            double discount = 0;
            //if (amount > 5 && amount <=10)
            //{
            //    discount = songPrice * amount * 5 / 100;
            //}
            //else if (amount > 10 && amount <= 20)
            //{
            //    discount = songPrice * amount * 12 / 100;
            //}
            //else if (amount > 20)
            //{
            //    discount = songPrice * amount * 50 / 100;
            //}

            switch (amount)
            {
                case (0):
                case (1):
                case (2):
                case (3):
                case (4):
                case (5):
                    discount = 0;
                    break;
                case (6): 
                case (7):
                case (8):
                case (9):
                case (10):
                    discount = songPrice * amount * 5 / 100;
                    break;
                case (11):
                case (12):
                case (13):
                case (14):
                case (15):
                case (16):
                case (17):
                case (18):
                case (19):
                case (20):
                    discount = songPrice * amount * 12 / 100;
                    break;
                default:
                    discount = songPrice * amount * 50 / 100;
                    break;
            }

            return discount;
        }
    }
}
