using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal interface ISpecificationRepository
    {
        Task<InfantrySpecification> GetInfantrySpecificationAsync(int unitId);
        Task AddInfantrySpecificationAsync(InfantrySpecification infantrySpecification);
        Task DeleteInfantrySpecificationAsync(InfantrySpecification specification);
        Task UpdateInfantrySpecificationAsync(InfantrySpecification infantrySpecification);

        Task<AircraftsSpecification> GetAircraftsSpecificationAsync(int unitId);
        Task AddAircraftSpecificationAsync(AircraftsSpecification aircraftSpecification);
        Task DeleteAircraftSpecificationAsync(AircraftsSpecification aircraftSpecification);
        Task UpdateAircraftSpecificationAsync(AircraftsSpecification aircraftSpecification);

        Task<VehicleSpecification> GetVehicleSpecificationAsync(int unitId);
        Task AddVehicleSpecificationAsync(VehicleSpecification vehicleSpecification);
        Task DeleteVehicleSpecificationAsync(VehicleSpecification vehicleSpecificationId);
        Task UpdateVehicleSpecificationAsync(VehicleSpecification vehicleSpecification);

        Task<HeavySpecification> GetHeavySpecificationsAsync(int unitId);
        Task AddHeavySpecificationAsync(HeavySpecification vehicleSpecification);
        Task DeleteHeavySpecificationAsync(HeavySpecification heavySpecification);
        Task UpdateHeavySpecificationAsync(HeavySpecification heavySpecification);


    }
}
