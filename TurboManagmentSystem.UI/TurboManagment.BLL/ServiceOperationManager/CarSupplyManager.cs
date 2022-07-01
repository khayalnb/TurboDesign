using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboManagment.BLL.Models;
using TurboManagment.BLL.DAL;
using TurboManagment.BLL.WarningMessages;

namespace TurboManagment.BLL.ServiceOperationManager
{
    public class CarSupplyManager
    {
        public static void AddCarSupply()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CarSupply carSupply = new CarSupply();
            
            bool isContiune;
            do
            {
                Console.WriteLine("Əlave et :");
                string carSupplyList = Console.ReadLine();
                carSupply.CarSupplyList.Add(carSupplyList);
                Console.WriteLine("Əlavə etmək istədiyiniz başqa avtomabil təchizatı var ? Hə/Yox");
                string result = Console.ReadLine();
                if (result.ToLower()=="he")
                {
                    isContiune = true;
                }
                else
                {
                    isContiune = false;
                }
            } while (isContiune);
           
            DataOperation.CarSupplies.Add(carSupply);
        }

        public static void ShowCarSupplyList()
        {
            int count = 0;
            foreach (var carsuplys in DataOperation.CarSupplies)
            {
                Console.WriteLine("Avtomabilin təchizatı");
                foreach (var item in carsuplys.CarSupplyList)
                {
                    count++;
                    Console.WriteLine($"{count}:{item}");

                }
            }
        } 
    }
}
