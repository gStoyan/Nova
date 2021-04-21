
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
using Nova.Data.Models;
using System.Linq;

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
        public void Service_CreatesAsync()
        {
            //Assert
            var model = new NovaModel()
            {
                Name = "test",
                ArmorPoints = 1,
                AttackPoints = 1,
                HealthPoints = 1,
                Range = 1
            };
            //Act
            services.CreateAsync(model);
            //Assert
            this.db.NovaModels.Any().Should().BeTrue();
        }
    }
}
