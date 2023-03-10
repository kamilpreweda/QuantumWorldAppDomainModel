using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class BuildingTests
    {
        [Fact]
       public void Building_UpgradeBuilding_Should_Increase_Its_Level_By_One()
        {
            var carbonFiberFactory = new CarbonFiberFactory();
            carbonFiberFactory.UpgradeBuilding();

            var expectedLevel = 1;
            var actualLevel = carbonFiberFactory.Level;

            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void Building_UpgradeBuilding_Should_Set_Its_New_Cost_Properly()
        {
            var carbonFiberFactory = new CarbonFiberFactory();
            carbonFiberFactory.UpgradeBuilding();

            List<Resource> expectedCost = new List<Resource>() {
                new CarbonFiberResource(300),
                new QuantumGlassResource(100)
            };

            List<Resource> actualCost = carbonFiberFactory.Cost;

            expectedCost.Should().BeEquivalentTo(actualCost);
        }

        [Fact]
        public void Building_UpgradeBuilding_Should_Set_Its_New_Time_To_Build_Properly()
        {
            var carbonFiberFactory = new CarbonFiberFactory();
            carbonFiberFactory.UpgradeBuilding();

            var expectedTime = TimeSpan.FromSeconds(4);
            var actualTime = carbonFiberFactory.TimeToBuild;

            Assert.Equal(expectedTime, actualTime);
        }
    }
}
