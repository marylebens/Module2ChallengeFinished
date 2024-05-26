/*
* Miles Per gallon Calculator
* Dr. Mary Lebens
* Last Updated 5/26/2024

* Calculates the miles per gallon based on the number of 
* miles driven and the number of gallons of gas used. 
* Prompts the user for the values.
*/

Console.Write("Enter the number of miles driven: ");
int milesDriven = int.Parse(Console.ReadLine());
Console.Write("Enter the number of gallons of gas used: ");
int gallonsUsed = int.Parse(Console.ReadLine());
double mpg = milesDriven / gallonsUsed;
Console.Write("Ths miles per gallon (MPG) is: " + mpg);