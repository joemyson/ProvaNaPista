using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class UserProduct : BaseProduct
    {

        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Stock { get; set; }
    }
}
