using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public abstract class Enemy
    {
        public string Name { get; protected set; }
        public EnemyType Type { get; protected set; }
        public abstract string Description { get; }
        public bool IsDefeated { get; protected set; }
        public TimeSpan TimeToAttack { get; protected set; }
        protected abstract TimeSpan BaseTimeToAttack { get; }
        protected abstract float TimeMultiplier { get; }        
        protected abstract List<Resource> Rewards { get; }        
        public bool IsUnderAttack { get; protected set; }
        public DateTime FinishDate { get; protected set; }
        public List<Ship> Ships { get; protected set; }

        public Enemy()
        {
            AutoSetBasicAttributes();
        }
        public int GetEnemyTotalHP()
        {
            int result = 0;
            foreach (var ship in Ships)
            {
                result += ship.GetTotalHP();
            }
            return result;  
        }
        public int GetEnemyTotalAP()
        {
            int result = 0;
            foreach (var ship in Ships)
            {
                result += ship.GetTotalAP();
            }
            return result;
        }
        public List<Resource> GetRewards() 
        {
            return Rewards;
        }        
        private void SetNewTime()
        {
            TimeToAttack = BaseTimeToAttack * TimeMultiplier;
        }
        private void AutoSetBasicAttributes()
        {
            SetName();
            SetType();
            SetNewTime();
        }
        private void SetName()
        {
            Name = this.GetType().Name;
        }
        private void SetType()
        {
            if (!Enum.IsDefined(typeof(EnemyType), Name))
            {
                throw new Exception("Enemy type not found.");
            }
            EnemyType enemyType;
            Enum.TryParse(Name, out enemyType);
            Type = enemyType;
        }
    }
}
