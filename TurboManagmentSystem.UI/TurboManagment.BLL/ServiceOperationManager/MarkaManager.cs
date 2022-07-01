using System;
using TurboManagment.BLL.DAL;
using TurboManagment.BLL.Models;
using TurboManagment.BLL.WarningMessages;

namespace TurboManagment.BLL.ServiceOperationManager
{
    public class MarkaManager
    {
        public static void AddMarka()
        {
            Marka marka = new Marka();
            Console.WriteLine(WarningAndErrorMessages.enterMessage);
            marka.Name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(marka.Name))
            {
                Console.WriteLine(WarningAndErrorMessages.emptyValueMessage);
                marka.Name = Console.ReadLine();
            }
            DataOperation.Markas.Add(marka);
        }
        public static void ShowMarka()
        {
            foreach (var marka in DataOperation.Models)
            {
                Console.WriteLine($"ID: {marka.Id}, Markanın adı: {marka.Name}");
            }
        }
    }
}
