using System.Collections.Generic;
using ResourceSystem.Data;

namespace ResourceSystem
{
    public class ResourceStorage
    {
        public Dictionary<ResourceTypes, int> Resources = new();

        public ResourceStorage()
        {
            Resources.Add(ResourceTypes.Crystals, 0);
            Resources.Add(ResourceTypes.Dust, 0);
            Resources.Add(ResourceTypes.Wood, 0);
        }
    }
}