using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1CarFactory_Test
{
    public class CarFactoryTests
    {
        // test  Type Assert 1
        [Fact]
        public void GetDirectionfor_CarTypesToyota_String()
        {
            // Arrange
            Car car = CarFactory.NewCar(CarTypes.Toyota)!;

            // Act
            string direction = car.GetDirection();

            // Assert
            Assert.IsType<string>(direction); 
        }

        // test Type Assert 2
        [Fact]
        public void GetMyCar_ReturnsCarType()
        {
            // Arrange
            BMW bmw = new BMW();

            // Act
            Car result = bmw.GetMyCar();

            // Assert
            Assert.IsAssignableFrom<Car>(result); 
        }

        //Collection Assert Contains &&  DeosNotContains
        [Fact]
        public void AddCar_AddsToCarStore_Contains()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Car toyota = CarFactory.NewCar(CarTypes.Toyota)!;
            Car audi = CarFactory.NewCar(CarTypes.Audi)!;

            // Act
            carStore.AddCar(toyota);

            // Assert
            Assert.Contains(toyota, carStore.cars); 
            Assert.DoesNotContain(audi, carStore.cars); 
        }

        // Exception Assert 1
        [Fact]
        public void Test_NewCar_ThrowsExceptionForUnknownType()
        {
            // Arrange
            CarTypes Honda  = CarTypes.Honda;

            Assert.Throws<NotImplementedException>(() =>
            {
                CarFactory.NewCar(Honda);
            });
        }

        // Test New Method ChangeDrivingMode
        [Fact]
        public void ChangeDrivingMode_DrivingModeBackward_Backward()
        {
            // Arrange
            Car car = CarFactory.NewCar(CarTypes.Toyota)!;
            DrivingMode newMode = DrivingMode.Backward;

            // Act
            car.ChangeDrivingMode(newMode);

            // Assert
            Assert.Equal(newMode, car.drivingMode);
        }

    }
}
