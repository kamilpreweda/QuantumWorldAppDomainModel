using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class EnemyTests
    {
        [Fact]
        public void Enemy_GetEnemyBaseShips_Should_Return_Proper_List_Of_Ships()
        {
            var piratesEnemy = new PiratesEnemy();
            piratesEnemy.GetEnemyBaseShips();

            List<Ship> expectedShips = new List<Ship>()
            {
                new LightFighterShip(10),
                new HeavyFighterShip(10),
            };

            List<Ship> actualShips = piratesEnemy.GetShips();

            expectedShips.Should().BeEquivalentTo(actualShips);
        }

        [Fact]
        public void Enemy_GetEnemyTotalAP_Should_Calculate_AP_Properly()
        {
            var outsidersEnemy = new OutsidersEnemy();            

            var expectedAP = 2000;
            var actualAP = outsidersEnemy.GetEnemyTotalAP();

            Assert.Equal(expectedAP, actualAP);
        }

        [Fact]
        public void Enemy_GetEnemyTotalHP_Should_Calculate_HP_Properly()
        {
            var outsidersEnemy = new OutsidersEnemy();

            var expectedHP = 3500;
            var actualHP = outsidersEnemy.GetEnemyTotalHP();

            Assert.Equal(expectedHP, actualHP);
        }

        [Fact]
        public void Enemy_GetRewards_Should_Return_Proper_List_Of_Resource()
        {
            var piratesEnemy = new PiratesEnemy();

            List<Resource> expectedRewards = new List<Resource>()
            {
                new CarbonFiberResource(2000),
                new QuantumGlassResource(2000)
            };

            List<Resource> actualRewards = piratesEnemy.GetRewards();

            actualRewards.Should().BeEquivalentTo(expectedRewards);
        }

        [Fact]
        public void Enemy_Get_Ships_Should_Return_Proper_List_Of_Ship()
        {
            var outsidersEnemy = new OutsidersEnemy();

            List<Ship> expectedShips = new List<Ship>()
            {
                new LightFighterShip(50),
                new HeavyFighterShip(50),
            };

            List<Ship> actualShips = outsidersEnemy.GetShips();

            actualShips.Should().BeEquivalentTo(expectedShips);
        }
    }
}
