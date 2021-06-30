using System.Threading.Tasks;
using ChoRealtime.Models.TokenAuth;
using ChoRealtime.Web.Controllers;
using Shouldly;
using Xunit;

namespace ChoRealtime.Web.Tests.Controllers
{
    public class HomeController_Tests: ChoRealtimeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}