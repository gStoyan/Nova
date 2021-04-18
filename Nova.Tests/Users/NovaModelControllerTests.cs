
using FluentAssertions;
using AutoMapper;
using Nova.Services.Areas.User;
using Nova.Services.Areas.User.Nova;
using Nova.Tests.Infrastructure;
using Nova.Web.Areas.User.Controllers.Home;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Nova.Web.Areas.User.Models;
using Nova.Data;
using Nova.Services.Model;

namespace Nova.Tests.Users
{
    public class NovaModelControllerTests
    {
        private NovaDbContext db = TestExtensions.GetDatabase();
        private Mapper mapper = new Mapper(new MapperConfiguration(cfg =>
                                    cfg.AddMaps(Assembly.Load(typeof(Program).Assembly.GetName().Name))));

        public NovaModelControllerTests()
        {
            this.db.NovaModels.Add(new Data.Models.NovaModel { Name = "Test" });
            this.db.SaveChanges();
        }
        [Fact]
        public async Task List_ReturnsView()
        {
            //Assert
            var novaModelsServices = new NovaModelServices(db,mapper);
            var novaModelController = new NovaModelController(novaModelsServices);
            //Act
            var result = await novaModelController.List();
            //Assert

            result.Should().BeOfType<ViewResult>();
        }
        [Fact]
        public async Task NovaServiceList_ReturnsElement()
        {
            //Assert
            var novaModelsServices = new NovaModelServices(db, mapper);
            //Act
            var element = await novaModelsServices.GetLastNovaModel();
            //Assert
            element.Name.Should().NotBe("");
        }
    }
}
