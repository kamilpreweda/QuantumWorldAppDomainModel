using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public interface IBattle
    {
        int GetTotalHP(List<Ship> ships);
        int GetTotalAP(List<Ship> ships);
        int Attack(int totalAP, int totalHP);
        void CalculateDestroyedShips(List<Ship> ships, int damage, out int remainingDamage);
        void StartBattle(List<Ship> playerShips, List<Resource> playerResources, Enemy enemy);
        void AssignRewards(List<Resource> playerResources, List<Resource> rewards);
        List<Resource> CollectRewards(Enemy enemy);
    }
}
