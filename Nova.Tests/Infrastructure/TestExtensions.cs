using Microsoft.EntityFrameworkCore;
using Nova.Data;
using System;
namespace Nova.Tests.Infrastructure
{
    public class TestExtensions
    {
        public static NovaDbContext GetDatabase()
        {
            var dbOptions = new DbContextOptionsBuilder<NovaDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new NovaDbContext(dbOptions);
        }
    }
}
