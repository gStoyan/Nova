using FluentAssertions;
using Nova.Data;
using Nova.Data.Initialisers;
using System.Linq;
using Xunit;

namespace Nova.Tests.Infrastructure
{
    public class InitialiserTests
    {
        private NovaDbContext db = TestExtensions.GetDatabase();
        
        public InitialiserTests()
        {

        }
        [Fact]
        public void NovaInitialiser_Creates()
        {
            //Arrage
            var novaInitialiser = new NovaModelInitialiser(this.db);
            //Act
             novaInitialiser.Initialise();
            //Assert
            this.db.NovaModels.Count().Should().BeGreaterThan(0);
        }
        [Fact]
        public void TextInitialiser_Creates()
        {
            //Arrange
            var textInitialiser = new TextInitialiser(this.db);
            //Act
            textInitialiser.Initialise();
            //Assert
            this.db.Texts.Count().Should().BeGreaterThan(0);
        }
        [Fact]
        public void Initialiser_Initialise_CallsAllClasses()
        {
            //Arrange
            var initialiser = new Initialiser(this.db);
            //Act
            initialiser.Initialise();
            //Assert
            this.db.NovaModels.Count().Should().BeGreaterThan(0);
            this.db.Texts.Count().Should().BeGreaterThan(0);
        }
    }
}
