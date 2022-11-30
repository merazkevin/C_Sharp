
Vehicle Nissan = new Vehicle("Nissan", 0, "green",false, 150);
Vehicle Dodge = new Vehicle("Dodge", "white");
Vehicle Chevy = new Vehicle("Chevy", 0, "red",false, 75);
Vehicle Bmw = new Vehicle("Bmw", "Black");

List<Vehicle> vehiclesList = new List<Vehicle>(); 
vehiclesList.Add(Nissan);
vehiclesList.Add(Dodge);
vehiclesList.Add(Chevy);
vehiclesList.Add(Bmw);
foreach(Vehicle vehicle in vehiclesList)
{
    vehicle.showInfo();
}

Nissan.Travel(65);
Nissan.showInfo();


// Create at least 4 different vehicles using any of the constructors (use each constructor at least once)
// Put all the vehicles you created into a List
// Loop through the List and have each vehicle run its ShowInfo() method
// Make one of the vehicles Travel 100 miles
// Print the information of the vehicle to verify the distance traveled went up
// Bonuses:
// Test this: manually set the distance traveled field to 350 and print the information. If your field was public, this will work. Why is this not the best practice to allow our users to change the distance traveled without going through the Travel() method?
// Once you know the answer, make the distance traveled field private. How does this affect the code in Program.cs now? Why is this better for us? Write comments in your code explaining your reasoning.