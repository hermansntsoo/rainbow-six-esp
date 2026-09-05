using R6Esp.Engine.Domain.Models;
using R6Esp.Persistence.Stores;

namespace R6Esp.Persistence.Repositories;

public sealed class VaultMetadataRepository
{
    private readonly SqliteWalletStore _store;

    public VaultMetadataRepository(SqliteWalletStore store)
    {
        _store = store;
    }

    public Task SaveAsync(WalletVault vault, CancellationToken cancellationToken) =>
        _store.SaveVaultAsync(vault, cancellationToken);

    public Task<WalletVault?> GetAsync(string vaultId, CancellationToken cancellationToken) =>
        _store.GetVaultAsync(vaultId, cancellationToken);

    public Task<IReadOnlyList<WalletVault>> ListAsync(CancellationToken cancellationToken) =>
        _store.ListVaultsAsync(cancellationToken);
}
