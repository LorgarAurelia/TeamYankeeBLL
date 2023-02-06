using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal class SpecificationRepository : ISpecificationRepository
    {
        public async Task<InfantrySpecification> GetInfantrySpecificationAsync(int unitId)
        {
            using TeamYankeeContext db = new();
            return await db.InfantrySpecifications.AsNoTracking().FirstAsync(i => i.UnitId == unitId);
        }
        public async Task AddInfantrySpecificationAsync(InfantrySpecification infantrySpecification)
        {
            using TeamYankeeContext db = new();
            db.InfantrySpecifications.Add(infantrySpecification);
            await db.SaveChangesAsync();
        }
        public async Task DeleteInfantrySpecificationAsync(InfantrySpecification specification)
        {
            using TeamYankeeContext db = new();
            db.InfantrySpecifications.Remove(specification);
            await db.SaveChangesAsync();
        }
        public async Task UpdateInfantrySpecificationAsync(InfantrySpecification specification)
        {
            using TeamYankeeContext db = new();
            var currentSpecification = db.InfantrySpecifications.Where(i => i.Id == specification.Id).First();
            currentSpecification = specification;//TODO: 
            await db.SaveChangesAsync();
        }


        public async Task<AircraftsSpecification> GetAircraftsSpecificationAsync(int unitId)
        {
            using TeamYankeeContext db = new();
            return await db.AircraftsSpecifications.AsNoTracking().FirstAsync( a => a.UnitId == unitId);
        }
        public async Task AddAircraftSpecificationAsync(AircraftsSpecification specification)
        {
            using TeamYankeeContext db = new();
            db.AircraftsSpecifications.Add(specification);
            await db.SaveChangesAsync();
        }
        public async Task DeleteAircraftSpecificationAsync(AircraftsSpecification specification)
        {
            using TeamYankeeContext db = new();
            db.AircraftsSpecifications.Remove(specification);
            await db.SaveChangesAsync();
        }
        public async Task UpdateAircraftSpecificationAsync(AircraftsSpecification specification)
        {
            using TeamYankeeContext db = new();
            var currentSpecification = db.AircraftsSpecifications.Where(s => s.Id == specification.Id).First();
            currentSpecification = specification; //TODO:
            await db.SaveChangesAsync();
        }


        public async Task<VehicleSpecification> GetVehicleSpecificationAsync(int unitId)
        {
            using TeamYankeeContext db = new();
            return await db.VehicleSpecifications.AsNoTracking().Where(s => s.UnitId == unitId).FirstAsync();
        }
        public async Task AddVehicleSpecificationAsync(VehicleSpecification specification)
        {
            using TeamYankeeContext db = new();
            db.VehicleSpecifications.Add(specification);
            await db.SaveChangesAsync();
        }
        public async Task DeleteVehicleSpecificationAsync(VehicleSpecification specification)
        {
            using TeamYankeeContext db = new();
            db.VehicleSpecifications.Remove(specification);
            await db.SaveChangesAsync();
        }
        public async Task UpdateVehicleSpecificationAsync(VehicleSpecification specification)
        {
            using TeamYankeeContext db = new();
            var currentSpecification = db.VehicleSpecifications.Where(s => s.Id == specification.Id).First();
            currentSpecification = specification; //TODO:
            await db.SaveChangesAsync();
        }


        public async Task<HeavySpecification> GetHeavySpecificationsAsync(int unitId)
        {
            using TeamYankeeContext db = new();
            return await db.HeavySpecifications.AsNoTracking().Where(s => s.UnitId == unitId).FirstAsync();
        }
        public async Task AddHeavySpecificationAsync(HeavySpecification specification)
        {
            using TeamYankeeContext db = new();
            db.HeavySpecifications.Add(specification);
            await db.SaveChangesAsync();
        }
        public async Task DeleteHeavySpecificationAsync(HeavySpecification specification)
        {
            using TeamYankeeContext db = new();
            db.HeavySpecifications.Remove(specification);
            await db.SaveChangesAsync();
        }
        public async Task UpdateHeavySpecificationAsync(HeavySpecification specification)
        {
            using TeamYankeeContext db = new();
            var currentSpecification = db.HeavySpecifications.Where(s => s.Id == specification.Id).First();
            currentSpecification = specification; //TODO:
            await db.SaveChangesAsync();
        }
    }
}
