// See https://aka.ms/new-console-template for more information


Console.WriteLine("Grade Calculator \n");

// Enter student subject 1 marks 
Console.WriteLine("Enter mathametics marks : ");
int mathametics = Convert.ToInt32(Console.ReadLine());

// Enter student subject 2 marks 
Console.WriteLine("Enter english marks : ");
int english = Convert.ToInt32(Console.ReadLine());

// Enter student subject 3 marks 
Console.WriteLine("Enter science marks :");
int science = Convert.ToInt32(Console.ReadLine());

// Calculate total marks 
int subjects = mathametics + english + science;

// Calculate percentage 
int average_marks = subjects / 3;

// Display the final result 
Console.WriteLine("averagemarks : " + average_marks);

{
    switch (average_marks / 10)
    {
    
        case 10:
        case 9:
            /* Marks between 90-100 */
            Console.WriteLine("\n Final Grade: A");
            break;
        case 8:
            /* Marks between 80-89 */
            Console.WriteLine("\n Final Grade: B");
            break;
        case 7:
            /* Marks between 70-79 */
            Console.WriteLine("\n Final Grade: C");
            break;
        case 6:
            /* Marks between 60-69 */
            Console.WriteLine("\n Final Grade: D");
            break;
        case 5:
            /* Marks below 60*/
            Console.WriteLine("\n Final Grade: f");
            break;
        default:
            Console.WriteLine("invalid input");
            break;

    }
}
