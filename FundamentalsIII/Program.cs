// 1. Iterate and print values

// Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)
List<string> names = new List<string>();
names.Add("kevin");
names.Add("Dereck");
names.Add("Mauricio");
names.Add("Alia");

// static void PrintList(List<string> MyList)
// {
// foreach(string items in MyList)
// {
// Console.WriteLine(items);
// }
// }
// PrintList(names);

//2. Print Sum
//Given a List of integers, calculate and print the sum of the values.
List<int> numbers = new List<int>();
numbers.Add(-1);
numbers.Add(-2);
numbers.Add(-3);
numbers.Add(-4);

// static void SumOfNumbers(List<int> IntList)
// { 
//     int sumOfNumberList = 0;
//     foreach(int number in IntList)
//     {
//         sumOfNumberList = sumOfNumberList + number;
//     }
//     Console.WriteLine(sumOfNumberList);
// }
// SumOfNumbers(numbers);

// 3. Find Max
// Given a List of integers, find and return the largest value in the List.
// static void FindMax(List<int> IntList)
// {
//     int maxNum = 0;
//     foreach( int number in IntList)
//         {
//             if(number > maxNum)
//             {
//             maxNum = number;
//             }
//         }
//     Console.WriteLine(maxNum);
// }
// FindMax(numbers);

// 4. Square the Values
// Given a List of integers, return the List with all the values squared. (Hint: use your PrintList method to check that it worked!)
// static List<int> SquareValues(List<int> IntList)
// {
//     for(int ii=0;ii<IntList.Count;ii++)
//     {
//         IntList[ii]=IntList[ii] * IntList[ii];
//         Console.WriteLine(IntList[ii]);
        
//     }
//     return IntList;
// }
// SquareValues(numbers);

// 5. Replace Negative Numbers with 0
// Given an array of integers, return the array with all values below 0 replaced with 0.
// int[] numbersArray = new int[4] {-1, 2,-3, 4};
// static int[] NonNegatives(int[] IntArray)
// {
//     for(int ii=0; ii< IntArray.Length;ii++)
//     {
//         if(IntArray[ii]<0)
//         {
//             IntArray[ii] = 0;
//             Console.WriteLine(IntArray[ii]);
//         }
//         else
//         {
//             Console.WriteLine(IntArray[ii]);
//         }
//     }
//     return IntArray;
// }
// NonNegatives(numbersArray);


// 6. Print Dictionary
// Given a dictionary, print the contents of the said dictionary.
// Dictionary<string,string> MyDictionary=  new Dictionary<string ,string>();
// MyDictionary.Add("firstName", "John");
// MyDictionary.Add("lastName", "doe");
// static void PrintDictionary(Dictionary<string,string> MyDictionary)
// {
//     foreach (KeyValuePair <string,string> item in MyDictionary)
//     {
//         Console.WriteLine(item);
//     }
// }
// PrintDictionary(MyDictionary);

// 7. Find Key
// Given a search term, return true or false whether the given term is a key in a dictionary.
// static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
// {
//     return MyDictionary.ContainsKey(SearchTerm)? true:false;
// }
// Console.WriteLine(FindKey(MyDictionary,"John"));

// 8. Generate a Dictionary
// Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 


static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string,int> newNamesDict=  new Dictionary<string,int>();
    for(int ii=0;ii < Names.Count;ii++){
        newNamesDict.Add(Names[ii],Numbers[ii]);
    }
    return newNamesDict;
}

Dictionary<string,int> lastDict = GenerateDictionary(names,numbers);
foreach(KeyValuePair<string,int> item in lastDict)
{
    Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
}