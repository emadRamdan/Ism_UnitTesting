using CarFactoryLibrary;

namespace Task1CarFactory_Test
{
    public class BMWTests
    {
        // String Assert 3
        [Fact]
        public void GetDirection_IncreaseVelocity10_Forward()
        {
            // Arrange
            Car BMW = CarFactory.NewCar(CarTypes.BMW)!;
            BMW.IncreaseVelocity(10);

            // Act
            string direction = BMW.GetDirection();

            // Assert
            Assert.NotEqual("Stopped", direction);
            Assert.Contains("war", direction);
            Assert.StartsWith("Fo", direction);
        }


        // Reference Assert 1
        [Fact]
        public void GetMyCar_AskForRefrence_NotSame()
        {
            // Arrange
            BMW bmw1 = new BMW();
            BMW bmw2 = new BMW() { drivingMode = DrivingMode.Stopped, velocity = 10 };

            // Act
            Car result = bmw2.GetMyCar();

            // Reference Assert
            Assert.NotSame(bmw1, result);
        }


        // Reference Assert 2
        [Fact]
        public void GetMyCar_AskForRefrenceBMW_Same()
        {
            // Arrange
            BMW bmw = new BMW();

            // Act
            Car result = bmw.GetMyCar();

            // Reference Assert
            Assert.Same(bmw, result);
        }


    }
}
