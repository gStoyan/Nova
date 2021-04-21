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
        public void NovaModelsInitialiser_Creates()
        {
            //Arrage
            var novaInitialiser = new NovaModelsInitialiser(this.db);
            //Act
             novaInitialiser.Initialise();
            //Assert
            this.db.NovaModels.Count().Should().BeGreaterThan(0);
        }
        [Fact]
        public void TextsInitialiser_Creates()
        {
            //Arrange
            var textInitialiser = new TextsInitialiser(this.db);
            //Act
            textInitialiser.Initialise();
            //Assert
            this.db.Texts.Count().Should().BeGreaterThan(0);
        }

        [Fact]
        public void WeaponsInitialiser_Creates()
        {
            //Arrange
            var weaponInitialiser = new WeaponsInitialiser(this.db);
            //Act
            weaponInitialiser.Initialise();
            //Assert
            this.db.Weapons.Count().Should().BeGreaterThan(0);

        }

        [Fact]
        public void OptionsInitialiser_Creates()
        {
            //Arrange
            var optionsInitialiser = new OptionsInitialiser(this.db);
            //Act
            optionsInitialiser.Initialise();
            //Assert
            this.db.Options.Count().Should().BeGreaterThan(0);
        }

        [Fact]
        public void UnitsInitialiser_Creates()
        {
            //Arrange
            var unitsInitialiser = new UnitsInitialiser(this.db);
            //Act
            unitsInitialiser.Initialise();

        }

        [Fact]
        public void ArmiesInitialiser_Creates()
        {
            //Arrange
            var armiesInitialiser = new ArmiesInitialiser(this.db);
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
