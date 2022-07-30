﻿/*
<Return type> <Name> (paramaters)
{
    return <type>;
}

int Sum(int paramater1, int paramater2){
    int sum = paramater1 + paramater2;
    return sum;
}
int SumFromMethod = Sum(2,2);
Console.WriteLine("The calculated sum from the method was " + SumFromMethod);

*/

void HelloMethod(string message){
    Console.WriteLine(message);
    return;
};

HelloMethod("This string matches the methods parameter input!");
//HelloMethod(1); //Doesn't work


int FibonacciExample()
{
    int firstNumber = 1;
    int secondNumber = 1;
    int nextNumber = 0;
    Console.WriteLine("How many of the fibonacci sequence numbers do you want me to calculate?");
    int input = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < input; i++)
    {
        nextNumber = firstNumber + secondNumber;
        Console.Write(" " + nextNumber);
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
    Console.WriteLine("Last number was : " + nextNumber)
    Console.WriteLine(""); //Some empty space
    Console.ReadLine(); 
}

int ReturnedNumber = FibonacciExample();




