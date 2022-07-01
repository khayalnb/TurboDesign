using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboManagment.BLL.Util;

namespace TurboManagment.BLL.Models
{
    public abstract class BaseIDGenerator
    {
        public long Id { get; set; }
        public BaseIDGenerator()
        {
            Id = CustomIdGenerator.GetCurrentTimeId();
        }
    }
}
