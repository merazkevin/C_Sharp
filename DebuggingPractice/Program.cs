// Challenge 1
//bool amProgrammer = "true"; //<=== wrong data type ===>
// <=== Correction ===> 
string amProgrammer = "true";

//int Age = 27.9; //<=== wrong data type ===>
// <=== Correction ===> 
Double Age = 27.9;

List<string> Names = new List<string>();
Names.Add = "Monica";
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
//MyDictionary.Add("Hi there", 0);//<=== wrong data type ===>
// <=== Correction ===> 
MyDictionary.Add("Hi there", "0");// missing -> (""). 
// This is a tricky one! Hint: look up what a char is in C#
//string MyName = 'MyName'; // missing -> ("").
// <=== Correction ===> 
string MyName = "MyName";

Console.WriteLine(amProgrammer);
Console.WriteLine(Age);
Console.WriteLine(MyName);