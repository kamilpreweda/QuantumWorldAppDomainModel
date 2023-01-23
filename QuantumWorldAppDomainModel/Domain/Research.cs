﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldAppDomainModel.Domain
{
    public abstract class Research
    {
        public string Name { get; protected set; }
        public ResearchType Type { get; protected set; }
        public abstract string Description { get; }
        public int Level { get; protected set; } = 0;
        public TimeSpan TimeToBuild { get; protected set; }
        protected abstract TimeSpan BaseTimeToBuild { get; }
        protected abstract float TimeMultiplier { get; }
        protected abstract float CostMultiplier { get; }
        protected abstract List<Resource> BaseCost { get; }
        public List<Resource> Cost { get; protected set; }
        public bool IsUnderConstruction { get; protected set; }
        public DateTime FinishDate { get; protected set; }

        public Research()
        {
            AutoSetBasicAttributes();
        }
        private void IncreaseLevel()
        {
            Level++;
        }
        private void SetNewCost()
        {
            foreach (var cost in Cost)
            {
                cost.Value *= CostMultiplier;
            }
        }
        private void SetNewTime()
        {
            TimeToBuild = BaseTimeToBuild * TimeMultiplier * (Level + 1);
        }
        private void AutoSetBasicAttributes()
        {
            SetName();
            SetType();
            SetCost();
            SetNewTime();
        }
        private void SetName()
        {
            Name = this.GetType().Name;
        }
        private void SetType()
        {
            if (!Enum.IsDefined(typeof(ResearchType), Name))
            {
                throw new Exception("Building type not found.");
            }
            ResearchType researchType;
            Enum.TryParse(Name, out researchType);
            Type = researchType;
        }
        private void SetCost()
        {
            Cost = BaseCost;
        }
        public void UpgradeResearch()
        {
            IncreaseLevel();
            SetNewCost();
            SetNewTime();

        }
    }
}