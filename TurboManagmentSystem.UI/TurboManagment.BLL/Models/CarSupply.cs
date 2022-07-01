using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboManagment.BLL.Models
{
    public class CarSupply:BaseIDGenerator
    {
        public CarSupply()
        {
            CarSupplyList=new List<string>();
        }
        List<string> CarSupplyList { get; set; }
    }
}
