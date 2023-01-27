using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public class User
    {
        private readonly IBattle _battle;
        public List<Resource> Resources { get; set; }
        public List<Building> Buildings { get; set; }
        public List<Research> Research { get; set; }
        public List<Ship> Ships { get; set; }
        public List<Enemy> Enemies { get; set; }
        public User(List<Resource> resources, List<Building> buildings, List<Research> research, List<Ship> ships, List<Enemy> enemies, IBattle battle)
        {
            Resources = resources;
            Buildings = buildings;
            Research = research;
            Ships = ships;
            Enemies = enemies;
            _battle = battle;
        }

        public void UpgradeBuilding(BuildingType type)
        {
            var building = Buildings.SingleOrDefault(b => b.Type == type);

            if (building == null)
            {
                throw new Exception("There is no such building.");
            }

            if (!CanAfford(building.Cost))
            {
                throw new Exception("Not enough resources.");
            }
                        
            SpendResources(Resources, building.Cost);
            building.UpgradeBuilding();
            
        }
        public void UpgradeResearch(ResearchType type)
        {
            var research = Research.SingleOrDefault(r => r.Type == type);

            if (research == null)
            {
                throw new Exception("There is no such research.");
            }

            if (CanAfford(research.Cost))
            {
                SpendResources(Resources, research.Cost);
                research.UpgradeResearch();
            }
        }
        public void BuildShip(ShipType type)
        {
            var ship = Ships.SingleOrDefault(s => s.Type == type);

            if (ship == null)
            {
                throw new Exception("There is no such ship.");
            }

            if (CanAfford(ship.Cost))
            {
                SpendResources(Resources, ship.Cost);
                ship.BuildShip();
            }
        }
        public void StartBattle(EnemyType type)
        {

            var enemy = Enemies.FirstOrDefault(e => e.Type == type);
            if (enemy == null)
            {
                throw new Exception("There is no such enemy");
            }
            _battle.StartBattle(Ships, Resources, enemy);
        }
        private bool CanAfford(List<Resource> cost)
        {
            foreach (var costResource in cost)
            {
                var currentPlayerResource = Resources.FirstOrDefault(r => r.Type == costResource.Type);
                if (currentPlayerResource == null)
                {
                    throw new Exception("There is no such resource.");
                }
                if (currentPlayerResource.Value < costResource.Value)
                {
                    return false;
                }
            }
            return true;
        }
        private void SpendResources(List<Resource> resources, List<Resource> cost)
        {
            foreach (var costResource in cost)
            {
                var currentPlayerResource = resources.Where(r => r.Type == costResource.Type).FirstOrDefault();
                if (currentPlayerResource == null)
                {
                    throw new Exception("There is no such resource.");
                }
                currentPlayerResource.Value -= costResource.Value;
            }
        }
                
    }
}

       

