using Microsoft.AspNetCore.Mvc;
using Nova.Data;
using Nova.Data.Models;
using Nova.Services.Areas.User;
using Nova.Services.Areas.User.Texts;
using Nova.Tests.Infrastructure;
using Nova.Web.Areas.Users.Controllers.Texts;
using Xunit;

namespace Nova.Tests.Users
{
    public class TextsControllerTests
    {
        TextsController controller;
        ITextServices  services;

        private NovaDbContext db = TestExtensions.GetDatabase();
        public TextsControllerTests()
        {
            this.services = new TextServices(this.db);
            controller = new TextsController(this.db, services);
        }

        [Fact]
        public void GetText_ByNovaId()
        {
            //Arrage
            int novaId = 1;
            this.db.NovaModels.Add(new NovaModel { Id = novaId, Name = "test" });
            this.db.Texts.Add(new Text { Id = 1,NovaModelId = novaId,Content = "test" });
            this.db.SaveChanges();
            //Act
            var ok = controller.GetNovaLastText(novaId);
            //Assert
            Assert.IsType<OkObjectResult>(ok.Result.Result);
        }
    }
    
}
