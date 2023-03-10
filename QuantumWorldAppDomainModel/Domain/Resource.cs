using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuantumWorldAppDomainModel.Domain
{
    public abstract class Resource
    {
        public string Name { get; set; }
        public ResourceType Type { get; set; }        
        protected abstract float BaseValue { get; }
        public float Value { get; set; }

        public Resource()
        {
            AutoSetBasicAttributes();
        }
        public Resource(float value)
        {
            AutoSetBasicAttributes();
            SetValue(value);
        }
        private void SetName()
        {
            Name = this.GetType().Name;
        }
        private void SetType()
        {
            if (!Enum.IsDefined(typeof(ResourceType), Name))
            {
                throw new Exception("Resource type not found.");
            }
            Type = (ResourceType)Enum.Parse(typeof(ResourceType), Name);            
        }
        private void SetValue(float value = -1)
        {
            Value = BaseValue;

            if (value > 0)
            {
                Value = (float)value;
            }
            
        }
        private void AutoSetBasicAttributes()
        {
            SetName();
            SetValue();
            SetType();
        }      
    }    
}
