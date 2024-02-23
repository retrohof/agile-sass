using System.Threading.Tasks;

namespace AgileSeo.Data;

public interface IAgileSeoDbSchemaMigrator
{
    Task MigrateAsync();
}
