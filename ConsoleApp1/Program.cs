// See https://aka.ms/new-console-template for more information
// Primitive Types
// Task1
int age = 24;
double GPA = 3.38;
string name = "Ahmad";
bool Employee = true;
Console.WriteLine($"Hello my name is {name}, my age is {age} ,my GPA is {GPA} am I an Employee? {Employee} ");
// Task 2
int number = 120;
double result = Convert.ToDouble(number);

Console.WriteLine
($"{result:00.00}");


// Bonus: we can use the char for methoeds such as the user can give an input of one letter 4ex Y and N so etheir yes or no
char letterY = 'Y';
char letterN = 'N';

// C# Variables
// Task1

double pointAverage = 3.38;
char studentGrade = 'A';
string studentName = "Ahmad";
string favoriteSubject = "Math";

Console.WriteLine(pointAverage);
Console.WriteLine(studentGrade);
Console.WriteLine(studentName);
Console.WriteLine(favoriteSubject);

// Task2 
double width = 8.5;
double height = 9.2;
double area = width * height;
Console.WriteLine("Area: "+area);


// Bouns: a cost can not chenge its value ,but a variable can change its value 

const int AhmadAge = 24;
var OsamaAge =  23 ;
Console.WriteLine(AhmadAge);
Console.WriteLine(OsamaAge);