using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSWPF.Model
{
    class BusCar : Car
    {

        public BusCar() { }

        public BusCarService GetListService()
        {

        }

        public abstract Order GetCostOrder()
        {
            return;
        }

        public abstract Order GetTotalCondition()
        {
            return;
        }
    }
}
