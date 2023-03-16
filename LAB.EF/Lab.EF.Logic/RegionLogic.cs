using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class RegionLogic : BaseLogic, IABMLogic<Region>

    {
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void Add(Region newRegion)
        {
            context.Region.Add(newRegion);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var regionAEliminiar = context.Region.Find(id);

            context.Region.Remove(regionAEliminiar);

            context.SaveChanges();
        }

        public void Update(Region region) 
        {
            var regionUpdate = context.Region.Find(region.RegionID);

            regionUpdate.RegionDescription = region.RegionDescription;

            context.SaveChanges();
        }
    }
}
