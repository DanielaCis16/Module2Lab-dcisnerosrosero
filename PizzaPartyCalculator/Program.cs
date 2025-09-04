//Declare variables
int numberOfGuests;
int slicesPerGuest = 3;  //Asume each guest eats 3 slices
int slicesPerPizza = 8; //Standard pizza has eight slices

//Prompt the user to enter the number of guests
Console.Write("Enter the number of guests: ");
//Call the Parse function turn the value the user entered into an int
numberOfGuests = int.Parse(Console.ReadLine());

//Calculate the total number of slices needed
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//Calculate the number of pizzas required
int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

//Display the output to the user
Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");

