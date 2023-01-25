using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public class PiratesEnemy : Enemy
    {
        public override string Description => "Pirates Description";

        public override List<Ship> Ships { get => Ships; protected set => Ships = value; }

        protected override TimeSpan BaseTimeToAttack => TimeSpan.FromSeconds(30);

        protected override float TimeMultiplier => 1;

        protected override List<Resource> Rewards => new List<Resource>()
        {
            new CarbonFiberResource(2000),
            new QuantumGlassResource(2000),
        };

        protected override List<Ship> BaseShips => new List<Ship>()
        {
            new LightFighterShip(10),
            new HeavyFighterShip(10),
        };
    }
}

        

