using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public class OutsidersEnemy : Enemy
    {
        public override string Description => "Outsiders Description";

        public override List<Ship> Ships { get => Ships; protected set => Ships = value; }

        protected override TimeSpan BaseTimeToAttack => TimeSpan.FromSeconds(60);

        protected override float TimeMultiplier => 1;

        protected override List<Resource> Rewards => new List<Resource>()
        {
            new CarbonFiberResource(5000),
            new QuantumGlassResource(5000),
        };

        protected override List<Ship> BaseShips => new List<Ship>()
        {
            new LightFighterShip(50),
            new HeavyFighterShip(50),
        };
    }
}
