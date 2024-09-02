using CS_HW1;

Car myCar = new Car("Toyota", "Camry", 2015, 50000);
Console.WriteLine($"Вік автомобіля: {myCar.Age} років");
myCar.Drive(100);
Console.WriteLine($"Пробіг автомобіля: {myCar.Mileage} км");
myCar.Drive(200, 2);

ElectricCar myElectricCar = new ElectricCar("Tesla", "Model S", 2020, 20000, 100);
Console.WriteLine($"Вік електромобіля: {myElectricCar.Age} років");
myElectricCar.Drive(50);
myElectricCar.Charge(20);
myElectricCar.Drive(300, 3);