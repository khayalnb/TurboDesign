using System;
using TurboManagment.BLL.Models;
using TurboManagment.BLL.ServiceOperationManager;

namespace TurboManagmentSystem.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            EnginePowerManager.AddEnginePower();
            EnginePowerManager.ShowEnginePower();


        }
    }
}
