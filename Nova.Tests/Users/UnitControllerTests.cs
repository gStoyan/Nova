
using AutoMapper;
using FluentAssertions;
using Nova.Data;
using Nova.Data.Models;
using Nova.Services.Areas.User.Units;
using Nova.Tests.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Nova.Tests.Users
{
    public class UnitControllerTests
    {
        private NovaDbContext db = TestExtensions.GetDatabase();
        private Mapper mapper = new Mapper(new MapperConfiguration(cfg =>
                                    cfg.AddMaps(Assembly.Load(typeof(Program).Assembly.GetName().Name))));
        public UnitControllerTests()
        {

        }
        [Fact]
        public async Task UnitController_Create()
        {
            //Assert
            var unitServices = new UnitServices(this.db);
            //Act
            var unit = new Unit
            {
                Name = "Test Unit"
            };
            this.db.Units.Add(unit);
            await this.db.SaveChangesAsync();
            //Assert
            this.db.Units.Count().Should().BeGreaterThan(0);
        }
    }
}
