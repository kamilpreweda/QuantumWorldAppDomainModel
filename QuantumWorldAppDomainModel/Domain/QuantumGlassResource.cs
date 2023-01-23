using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public class QuantumGlassResource : Resource
    {
        protected override float BaseValue => 500;

        public QuantumGlassResource() :base() 
        {
        
        }
        public QuantumGlassResource(float value) : base(value) 
        {

        }
    }
}
