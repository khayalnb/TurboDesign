using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboManagment.BLL.ServiceOperationManager;

namespace TurboManagment.BLL.ServiceOperationManager
{
    public class BaseManager
    {
        public static void ShowAllProductInfo()
        {
            bool isContiune;
            do
            {
                Console.WriteLine("Elan yerlesdir (1)");
                Console.WriteLine("Markaya bax (2)");

                int result = int.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        isContiune = true;  
                        Console.WriteLine();
                        MarkaManager.AddMarka();
                        ModelManager.AddModel();
                        BanTypeManager.AddBanType();
                        FuelTypeManager.AddFuelType();
                        EnginePowerManager.AddEnginePower();
                        break;
                    case 2:
                        isContiune = true;
                        MarkaManager.ShowMarka();
                        ModelManager.ShowModel();
                        BanTypeManager.ShowBanType();
                        FuelTypeManager.ShowFuelType();
                        EnginePowerManager.ShowEnginePower();
                        break;
                    case 3:
                        isContiune = false;
                        break;
                    default:
                        if (result > 3)
                            Console.WriteLine("Duzgun secim edilmedi");
                        isContiune = true;
                        break;
                }
            } while (isContiune);
           
        } 
    }
}
