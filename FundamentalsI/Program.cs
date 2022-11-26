// <=== Fundamentals I ===>
// Create a loop that prints all values from 1-255.
// <=== for loop ===>
    // for(int ii=1;ii<=255;ii++)
    // {
    //     Console.WriteLine(ii);
    // }
    // <=== While loop ===>
    // int ii=1;
    // while(ii<=255){
    //     Console.WriteLine(ii);
    //     ii++;
    // }

// Create a new loop that generates 5 random numbers between 10 and 20 and print out the sum of these values.

// <=== For Loop ===>
// Random rand = new Random();
// int sumOfI=0;
// for(int ii = 1; ii <= 5; ii++){
//     int num= rand.Next(10,20);
//     Console.WriteLine("<=== This is the random Numbers ===>");
//     Console.WriteLine(num);
//     sumOfI=sumOfI+num;
// }
// Console.WriteLine("<=== this is the SumOfI ===>");
// Console.WriteLine(sumOfI);

// <=== while loop ===>
// int ii = 1;
// int sumOfII=0;
// Random rand = new Random();
// while(ii<=5){
//     int num = rand.Next(10,20);
//     Console.WriteLine(" <=== This is the Random Number ===>");
//     Console.WriteLine(num);
//     sumOfII=sumOfII+num;
//     ii++;
// }
// Console.WriteLine("<=== This is the sumOfII ===>");
// Console.WriteLine(sumOfII);


// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.

// <=== For loop ===>
// for(int ii=1;ii<=100; ii++){
// if(ii%3==0 && ii%5==0){
//     ii++;
//     }
//     else if(ii%3==0 || ii%5==0){
//         Console.WriteLine("this is ii div by 3 Or 5");
//         Console.WriteLine(ii);
//         }
// }

// <=== While loop***** ===>
// int ii= 1;
// while(ii<=100){
//     if (ii%3==0 && ii%5==00)
//     {
//         ii++;
//     }
//     else if (ii%3==0 || ii%5==0){
//         Console.WriteLine("<=== div by 3 OR 5 not Both ===>");
//         Console.WriteLine(ii);
//     } 
//     ii++;
// }

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

// <=== For loop ===>
    // for(int ii=1; ii<=100; ii++)
    //     if (ii%3==0)
    //     {
    //         Console.WriteLine("<=== div by 3 ===>");
    //         Console.WriteLine("Fizz");
    //     }else if (ii%5==0){
    //         Console.WriteLine("<=== div by 5 ===>");
    //         Console.WriteLine("Buzz");
    //     }

// <=== For while ===>
    // int ii= 1;
    // while(ii<=100){
    //     if (ii%3==0)
    //     {
    //         Console.WriteLine("<=== div by 3 ===>");
    //         Console.WriteLine("Fizz");
    //     }else if (ii%5==0){
    //         Console.WriteLine("<=== div by 5 ===>");
    //         Console.WriteLine("Buzz");
    //     } 
    //     ii++;}
    


// Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.

// <=== For loop ===>
    // for(int ii=1; ii<=100; ii++)
    //     if (ii%3==0 && ii%5==0){
    //         Console.WriteLine("<=== div by 3 & 5 ===>");
    //         Console.WriteLine("FizzBuzz");
    //     }else if (ii%3==0){
    //         Console.WriteLine("<=== div by 5 ===>");
    //         Console.WriteLine("Fizz");
    //     }else if (ii%5==0){
    //         Console.WriteLine("<=== div by 3 & 5 ===>");
    //         Console.WriteLine("Buzz");
    //     }

// <=== while Loop ===>
    // int ii = 1;
    // while(ii<=100){
    //     if (ii%3==0 && ii%5==0){
    //         Console.WriteLine("<=== div by 3 & 5 ===>");
    //         Console.WriteLine("FizzBuzz");
    //     }else if (ii%3==0){
    //         Console.WriteLine("<=== div by 5 ===>");
    //         Console.WriteLine("Fizz");
    //     }else if (ii%5==0){
    //         Console.WriteLine("<=== div by 3 & 5 ===>");
    //         Console.WriteLine("Buzz");
    //     }
    //     ii++;}

// (Optional) If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!