using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AgileSeo.Data;

/* This is used if database provider does't define
 * IAgileSeoDbSchemaMigrator implementation.
 */
public class NullAgileSeoDbSchemaMigrator : IAgileSeoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
