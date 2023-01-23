using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public class CarbonFiberFactory : Building
    {
        public override string Description => "Carbon Fiber Factory Description";

        protected override float CostMultiplier => 2;

        protected override float TimeMultiplier => 2;

        protected override TimeSpan BaseTimeToBuild => TimeSpan.FromSeconds(2);

        protected override List<Resource> BaseCost => new List<Resource>() 
        {
            new CarbonFiberResource(150),
            new QuantumGlassResource(50),
        };
    }
}
