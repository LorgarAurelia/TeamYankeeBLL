using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal interface ISpecificationRepository
    {
        Task<InfantrySpecification> GetInfantrySpecificationAsync(int unitId);
        Task AddInfantrySpecificationAsync(InfantrySpecification infantrySpecification);
        Task DeleteInfantrySpecificationAsync(int specificationId);
        Task UpdateInfantrySpecificationAsync(InfantrySpecification infantrySpecification);

        Task<AircraftsSpecification> GetAircraftsSpecificationAsync(int unitId);
        Task AddAircraftSpecification(AircraftsSpecification aircraftSpecification);
        Task DeleteAircraftSpecification(int aircraftSpecificationId);
        Task UpdateAircraftSpecificationAsync(AircraftsSpecification aircraftSpecification);

        Task<VehicleSpecification> GetVehicleSpecificationAsync(int unitId);
        Task AddVehicleSpecification(VehicleSpecification vehicleSpecification);
        Task DeleteVehicleSpecificationAsync(int vehicleSpecificationId);
        Task UpdateVehicleSpecificationAsync(VehicleSpecification vehicleSpecification);

        Task<HeavySpecification> GetHeavySpecificationsAsync(int unitId);
        Task AddHeavySpecification(HeavySpecification vehicleSpecification);
        Task DeleteHeavySpecification(int heavySpecificationId);
        Task UpdateHeavySpecification(HeavySpecification heavySpecification);


    }
}
