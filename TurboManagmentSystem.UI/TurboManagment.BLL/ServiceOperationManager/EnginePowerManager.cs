using System;
using TurboManagment.BLL.DAL;
using TurboManagment.BLL.Models;
using TurboManagment.BLL.WarningMessages;
namespace TurboManagment.BLL.ServiceOperationManager
{
    public class EnginePowerManager
    {
        public static void AddEnginePower()
        {
            EnginePower enginePower = new EnginePower();
            Console.WriteLine(WarningAndErrorMessages.enterMessage);
            string _enginePower = Console.ReadLine();
            short enginePowerResponse;
            while (!short.TryParse(_enginePower, out enginePowerResponse))
            {
                 Console.WriteLine(WarningAndErrorMessages.wrongValueMessage);
                 _enginePower = Console.ReadLine();
            }
            enginePower.HorsePowerNumber = enginePowerResponse;
            DataOperation.EnginePowers.Add(enginePower);
        }
        public static void ShowEnginePower()
        {
            foreach (var enginePower in DataOperation.EnginePowers)
            {
                Console.WriteLine($"ID: {enginePower.Id} , Avtomabilin at gücü: {enginePower.HorsePowerNumber}");
            }
        }
      
    }
}
