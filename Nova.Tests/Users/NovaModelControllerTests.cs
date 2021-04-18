
using FluentAssertions;
using AutoMapper;
using Nova.Services.Areas.User;
using Nova.Services.Areas.User.Nova;
using Nova.Tests.Infrastructure;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Nova.Web.Areas.User.Models;
using Nova.Data;
using Nova.Services.Model;
using Nova.Web.Areas.Users.Controllers.NovaModels;

namespace Nova.Tests.Users
{
    public class NovaModelControllerTests
    {
        NovaModelsController controller;
        INovaModelServices services;

        private NovaDbContext db = TestExtensions.GetDatabase();
        private Mapper mapper = new Mapper(new MapperConfiguration(cfg =>
                                    cfg.AddMaps(Assembly.Load(typeof(Program).Assembly.GetName().Name))));
        public NovaModelControllerTests()
        {
            this.services = new NovaModelServices(this.db,this.mapper);
            controller = new NovaModelsController(this.db,this.services);
            
        }
        //Controller
        [Fact]
        public  void Get_WhenCalled_ReturnsResult()
        {
            //Act
            var ok =  controller.GetNovaModelsAsync().Result;

            //Assert
            Assert.IsType<OkObjectResult>(ok.Result);
        }
        [Fact]
        public void Get_ById_ReturnsResult()
        {
            //Assert
            int id = 1;
            //Act
            var ok =  this.controller.GetNovaModelAsync(id).Result;
            //Assert
            Assert.IsType<OkObjectResult>(ok.Result);
        }

        //Services
        [Fact]
        public async Task NovaServices_ReturnsElement()
        {
            //Arrange
            this.db.NovaModels.Add(new Data.Models.NovaModel { Name = "Test" });
            this.db.SaveChanges();
            var novaModelsServices = new NovaModelServices(db, mapper);
            //Act
            var element = await novaModelsServices.GetLastNovaModel();
            //Assert
            element.Name.Should().NotBe("");
        }

      

    }
}
