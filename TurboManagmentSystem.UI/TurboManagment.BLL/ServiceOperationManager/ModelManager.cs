using System;
using TurboManagment.BLL.DAL;
using TurboManagment.BLL.Models;
using TurboManagment.BLL.WarningMessages;

namespace TurboManagment.BLL.ServiceOperationManager
{
    public class ModelManager
    {
        public static void AddModel()
        {
            Model model = new Model();
            Console.WriteLine(WarningAndErrorMessages.enterMessage);
            model.Name = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(model.Name))
            {
                Console.WriteLine(WarningAndErrorMessages.emptyValueMessage);
                model.Name = Console.ReadLine();
            }
        }
        public static void ShowModel()
        {
            foreach (var model in DataOperation.Models)
            {
                Console.WriteLine($"ID: {model.Id}, Modelin adi {model.Name}");

            }
        }
    }
}
