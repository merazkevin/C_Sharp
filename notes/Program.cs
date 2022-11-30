// Random rand = new Random();
// for(int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(rand.Next(2,8));
// }

// Declaring an array of length 5, initialized by default to all zeroes
// int[] numArray = new int[5];
// Declaring an array with pre-populated values
// For arrays initialized this way, the length is determined by the size of the given data
// int[] numArray2 = {1,2,3,4,6};
// int ii=0;
// while(ii<5){
// Console.WriteLine(numArray2[ii]);
// ii++;
// }
// foreach(int number in numArray2){
//     Console.WriteLine($"this is the current iteratin {number}");
// }

// int[] array3; // Declared without initializing a size
// array3 = new int[] {1,3,5,7,9}; // We can now fill the array by using the new operator
// array3[1]=0;
// int ii=0;
// while(ii<array3.Length){
// Console.WriteLine(array3[ii]);
// ii++;
// }

// int[] arr = {1, 2, 3, 4};
// Console.WriteLine($"The first number of the arr is {arr[0]}"); 
// arr[0] = 8;
// Console.WriteLine($"The first number of the arr is now {arr[0]}");
// // The array has now changed!

// string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
// foreach (string car in myCars)
// {
//     // We no longer need the index, because variable 'car' already represents each indexed value
//     Console.WriteLine($"I own a {car}");
// }

// Create an array of integers that will hold 8 values. (Do not fill in the values, just create 8 slots.)
// int[] newArray= new int[8];
// Place the number 17 in the third spot of your array. (Think carefully about the index number you need to make this happen!)
// newArray[2]=17;
// Try to place the word "Hello" in the fifth spot. What happens?
// newArray[4]="hello";
// Loop through your array and print out the values.
// foreach(int number in newArray){
//     Console.WriteLine($"this is the Array {number}");
// }
// If you did the above action with a for loop, do it again but with a foreach loop.
// Console.WriteLine($"this are the Array indexes' values [{string.Join(",",newArray)}]");
// Try to Console.WriteLine your array. What result do you get? Weird, right? Do a bit of research on this to find out why it happens and how to work around it!

// // Initializing an empty list of Motorcycle Manufacturers that expects string values
// List<string> bikes = new List<string>();
// // Use the Add function in a similar fashion to push
// bikes.Add("Kawasaki");
// bikes.Add("Triumph");
// bikes.Add("BMW");
// bikes.Add("Moto Guzzi");
// bikes.Add("Harley Davidson");
// bikes.Add("Suzuki");
// // Accessing a generic list value is the same as you would an array
// Console.WriteLine(bikes[2]); //Prints "BMW", remember we start at 0!
// // To get the size of a List, we use Count instead of Length
// Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

// // Using our list of motorcycle manufacturers from before
// // we can easily loop through the list of them with a for loop
// // this time, however, Count is the attribute for a number of items.
// Console.WriteLine("The current manufacturers we have seen are:");
// for (int idx = 0; idx < bikes.Count; idx++)
// {
//     Console.WriteLine("-" + bikes[idx]);
// }
// // Insert a new item between a specific index
// bikes.Insert(2, "Yamaha");
// // Removal from List
// // Remove is a lot like Javascript array pop, but searches for a specified value
// bikes.Remove("Suzuki");
// bikes.Remove("Yamaha");
// // We can also remove from a specific index
// bikes.RemoveAt(0); 
// // RemoveAt has no return value however, so we cannot get back what we removed
// // The updated list can then be iterated through using a foreach loop
// Console.WriteLine("List of Non-Japanese Manufacturers:");
// foreach (string manu in bikes)
// {
//     Console.WriteLine("-" + manu);
// }

// List<int> MyNums = new List<int>();
// MyNums.Add(2);
// MyNums.Add(-1);
// MyNums.Add(7);
// MyNums.Add(9);
// MyNums.Add(12);

// for(int i =0; i< MyNums.Count+1;i++)
// {
//     Console.WriteLine(MyNums[i]);
// }

// static void SayHello(string firstName = "buddy")
// {
//     Console.WriteLine($"Hey, {firstName}");
// }
// // We can call it without providing any arguments and the default value will be used...
// SayHello();
// // ...or we can call it with an argument and that argument's value will be used
// SayHello("Yoda");

// Console.WriteLine("Type something, then hit enter: ");
// string InputLine = Console.ReadLine();
// Console.WriteLine($"You wrote: {InputLine}");

// Console.WriteLine("Type a number, then hit enter: ");
// string NumberInput = Console.ReadLine();
// Console.WriteLine(10 + NumberInput);

Console.WriteLine("Type a number, then hit enter: ");
string NumberInput = Console.ReadLine();
// TryParse takes 2 parameters: the item to be parsed and a variable
// you would like to output (out) to if it is successful
if(Int32.TryParse(NumberInput, out int j))
{
    // Notice how we used j instead of NumberInput
    Console.WriteLine($"The integer was {j}");
    Console.WriteLine(10 + j);
}