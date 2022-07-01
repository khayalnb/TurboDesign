using System;
using TurboManagment.BLL.Models;
using TurboManagment.BLL.DAL;
using TurboManagment.BLL.WarningMessages;

namespace TurboManagment.BLL.ServiceOperationManager
{
    public class BanTypeManager
    {
        public static void AddBanType()
        {
            BanType banType = new BanType();
            Console.WriteLine(WarningAndErrorMessages.enterMessage);
            banType.Name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(banType.Name) || int.TryParse(banType.Name,out int a))
            {
                Console.WriteLine(WarningAndErrorMessages.wrongValueMessage);
                banType.Name = Console.ReadLine();
            }
            DataOperation.BanTypes.Add(banType);
        }
        public static void ShowBanType()
        {
            foreach (var bantype in DataOperation.BanTypes)
            {
                Console.WriteLine($"ID {bantype.Id} Ban növü {bantype.Name}");
            }
        }
    }
}
