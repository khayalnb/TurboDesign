using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboManagment.BLL.Models
{
    public class Color:BaseIDGenerator
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
