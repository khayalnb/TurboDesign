using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboManagment.BLL.DAL
{
    class DataOperation
    {
        public static List<Models.Model> Models { get; set; }
        public static List<Models.Marka> Markas { get; set; }
        public static List <Models.BanType> BanTypes { get; set; }
        public static List<Models.TransMissionType> TransMissionTypes { get; set; }
        public static List <Models.TransMitterType> TransMitterTypes { get; set; }
        public static List<Models.MoneyType> MoneyTypes { get; set; }
        public  static List <Models.EngineCapacity> EngineCapacities{ get; set; }
        public static List<Models.EnginePower> EnginePowers { get; set; }
        public static List<Models.MarchType> MarchTypes { get; set; }
        public static List<Models.Color> Colors { get; set; }
        public static List<Models.FuelType> FuelTypes { get; set; }
        public static List<Models.Year> Years { get; set; }
        public static List<Models.CarSupply> CarSupplies { get; set; }

        static DataOperation()
        {
            Models = new List<Models.Model>(); 

            Markas = new List<Models.Marka>();

            BanTypes = new List<Models.BanType>();

            TransMissionTypes = new List<Models.TransMissionType>();

            TransMitterTypes = new List<Models.TransMitterType>();

            MoneyTypes = new List<Models.MoneyType>();

            EngineCapacities = new List<Models.EngineCapacity>();

            EnginePowers = new List<Models.EnginePower>();

            MarchTypes = new List<Models.MarchType>();

            Colors = new List<Models.Color>();

            FuelTypes = new List<Models.FuelType>();

            Years = new List<Models.Year>();
              
            CarSupplies = new List<Models.CarSupply>();
        }
    }
}
