using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AgileSeo.Pages;

public class Index_Tests : AgileSeoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
