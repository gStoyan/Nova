
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
using Nova.Services.Areas.User.Texts;
using Microsoft.EntityFrameworkCore;

namespace Nova.Tests.Users
{
    public class NovaModelControllerTests
    {
        NovaModelsController controller;
        INovaModelServices services;
        ITextServices textServices;
        private NovaDbContext db = TestExtensions.GetDatabase();
        
        public NovaModelControllerTests()
        {
            this.textServices = new TextServices(this.db);
            this.services = new NovaModelServices(this.db, textServices);
            controller = new NovaModelsController(this.db,this.services);
        }
        //Controller
        [Fact]
        public  void Get_WhenCalled_ReturnsResult()
        {
            this.services.GetNovaModelAsync(1);
            //Act
            var ok =  controller.GetNovaModelsAsync().Result;

            //Assert
            Assert.IsType<OkObjectResult>(ok);
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

        [Fact]
        public void Post_Creates()
        {
            //Arrange
            var model = new NovaModel()
            {
                Name = "test",
                ArmorPoints = 1,
                AttackPoints = 1,
                HealthPoints = 1,
                Range = 1
            };
            //Act
            var result = this.controller.PostNovaModelAsync(model);
            //Assert
            this.db.NovaModels.Any().Should().BeTrue();
        }
        //Services

        [Fact]
        public void Service_CreatesAndAddsFirstText()
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
            var text = new Text()
            {
                NovaModelId = 1,
                Content = "Test",
                Title = "Test"

            };
            //Act
            this.db.Texts.Add(text);
            this.db.SaveChangesAsync();
            services.CreateAsync(model);
            //Assert
            this.db.NovaModels.Any().Should().BeTrue();
            var novaId = this.db.NovaModels.Where(n => n.Name == model.Name).First().Id;
            
            this.db.NovaModels.Include(n => n.Texts).First().Texts.Count.Should().BeGreaterThan(0);
        }
    }
}
