using CarFactoryLibrary;

namespace Task1CarFactory_Test
{
    public class ToyotaTests
    {
        // Boolean Assert
        [Fact]
        public void Equals_ToyotaEqualisNull_False()
        {
            // Arrange
            Toyota toyota1 = new Toyota();
            Toyota toyota2 = new Toyota() { velocity=10} ;

            // Act
            bool Equals = toyota1.Equals(toyota2);

            // Assert
            Assert.False(Equals);
        }

        //Numeric Assert 1
        [Fact]
        public void TimeToCoverDistance_ToyotaVelocity60andDistance120_2()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 60 };

            // Act
            double time = toyota.TimeToCoverDistance(120);

            // Assert
            Assert.Equal(2, time);
        }

        //Numeric Assert 2
        [Fact]
        public void Accelerate_velocity10_15()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 10 };


            // Act
               toyota.Accelerate(); 

            // Assert
            Assert.Equal(15,toyota.velocity);
        }

        // String Assert 3
        [Fact]
        public void GetDirection_ToyotoVelocity0_Stooped()
        {
            // Arrange
            Car car = CarFactory.NewCar(CarTypes.Toyota)!;

            // Act
            string direction = car.GetDirection();

            // Assert
            Assert.Equal("Stopped", direction);
            Assert.Contains("St", direction);
            Assert.EndsWith("ed", direction);
        }



    }
}