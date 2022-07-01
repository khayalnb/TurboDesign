using System;
using TurboManagment.BLL.DAL;
using TurboManagment.BLL.Models;
using TurboManagment.BLL.WarningMessages;

namespace TurboManagment.BLL.ServiceOperationManager
{
    public class FuelTypeManager
    {
       public static void AddFuelType()
       {
            FuelType fuelType = new FuelType();
            Console.WriteLine(WarningAndErrorMessages.enterMessage);
            fuelType.Name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(fuelType.Name))
            {
                Console.WriteLine(WarningAndErrorMessages.emptyValueMessage);
                fuelType.Name = Console.ReadLine();
            }
            DataOperation.FuelTypes.Add(fuelType);
       }
        public static void ShowFuelType()
        {
            foreach (var fuelType in DataOperation.FuelTypes)
            {
                Console.WriteLine($"ID {fuelType.Id} Yanacaqin novu {fuelType.Name}");
            }
        }
    }
}
