using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public class CarbonFiberResource : Resource
    {
        protected override float BaseValue => 500;

        public CarbonFiberResource() : base()
        {

        }
        public CarbonFiberResource(float value) : base(value)
        {

        }
    }
}
