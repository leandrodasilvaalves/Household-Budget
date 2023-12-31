using Household.Budget.Contracts.Models;

namespace Household.Budget.Contracts.Data
{
    public interface IImportedSeedConfigRespository
    {
        Task<ImportedSeedConfig> GetAsync(CancellationToken cancellationToken = default);
        Task SaveAsync(ImportedSeedConfig seedConfig, CancellationToken cancellationToken = default);
        Task<bool> RootUserHasBeenCreatedAsync(CancellationToken cancellationToken = default);
        Task<bool> CategoriesHasBeenImportedAsync(CancellationToken cancellationToken = default);
    }
}