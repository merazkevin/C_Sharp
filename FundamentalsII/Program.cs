// Three Basic Arrays
// Create an array with the integers 0 through 9 inside.
int[] numsArray = {1,2,3,4,5,6,7,8,9};
// Create an array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] namesArray = new string[] {"Tim", "Nikki", "Sara"};
// Create an array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
Random rand = new Random();
bool[] boolArray = new bool[10];
int ii =1;
while(ii<=9){
    int num = rand.Next(1,3);
    if(num==1){
        boolArray[ii]=true;
        ii++;
    }
    else{
        boolArray[ii]=false;
        ii++;
    }
}
// Console.WriteLine(String.Join(",",boolArray));

// List of Flavors
// Create a List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> flavors = new List<string>();
flavors.Add("vanilla");
flavors.Add("Chocolate");
flavors.Add("Straberry");
flavors.Add("BlueBerry");
flavors.Add("Mint");
foreach(string flavor in flavors){
    // Console.WriteLine(flavor);
}

// Output the length of the List after you added the flavors.
foreach(string flavor in flavors){
    // Console.WriteLine(flavor);
}
// Console.WriteLine(flavors.Count);

// Output the third flavor in the List.
// Console.WriteLine(flavors[2]);

// Now remove the third flavor using its index location.
flavors.Remove(flavors[2]);
// Output the length of the List again. It should now be one fewer.
foreach(string flavor in flavors){
    // Console.WriteLine(flavor);
}
// Console.WriteLine(flavors.Count);


// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string,string> newDict = new Dictionary<string, string>(); 

// Add key/value pairs to the dictionary where:
// Each key is a name from your names array.
// Each value is a randomly selected flavor from your flavors List
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
foreach(string name in namesArray){
        int RandomIndexNum = rand.Next(0,4);
        string Randflavor = flavors[RandomIndexNum];
        newDict.Add(name,Randflavor);
    };

foreach(KeyValuePair<string,string> key in newDict){
Console.WriteLine(key);
}


