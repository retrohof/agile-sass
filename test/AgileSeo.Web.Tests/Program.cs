using Microsoft.AspNetCore.Builder;
using AgileSeo;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AgileSeoWebTestModule>();

public partial class Program
{
}
