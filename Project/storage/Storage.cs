using Project.enums;
using Project.techniques;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.storage
{
    class Storage
    {
        private List<Technique> _modelStore;
        private HashSet<TechniqueType> _availableTypes;

        public Storage()
        {
            _modelStore = new List<Technique>();
            _availableTypes = new HashSet<TechniqueType>();
        }

        internal HashSet<TechniqueType> AvailableTypes { get => _availableTypes; }
        internal List<Technique> ModelStore { get => _modelStore; set => _modelStore = value; }

        public void InitStorage()
        {
            _modelStore.Add(new Notebook("SONY", 3));
            _modelStore.Add(new Smartphone("SONY", 5));
            _modelStore.Add(new Smartphone("Apple", 4));
            GetAvailableTypes();
        }

        private void GetAvailableTypes()
        {
            foreach (Technique technique in _modelStore)
            {
                _availableTypes.Add(technique.Type);
            }
        }

        public List<Technique> GetTechniqueType(TechniqueType type)
        {
            List<Technique> techniqueList = new List<Technique>();
            foreach (Technique technique in _modelStore)
            {
                if (technique.Type == type)
                    techniqueList.Add(technique);
            }
            return techniqueList;
        }
    }
}