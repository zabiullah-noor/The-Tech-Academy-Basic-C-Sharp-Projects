Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Ask the user to enter the package weight.
Console.Write("Please enter the package weight: ");
// Read the user's weight and convert it from text to a decimal number.
decimal weight = Convert.ToDecimal(Console.ReadLine());

// Check if the package weight is greater than 50.
if (weight > 50)
{
    // Display the required error message if the package is too heavy.
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

    // Stop the program because the package cannot be shipped.
    return;
}// Ask the user to enter the package width.
Console.WriteLine("Please enter the package width:");

// Read and convert the package width.
decimal width = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter the package height.
Console.WriteLine("Please enter the package height:");

// Read and convert the package height.
decimal height = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter the package length.
Console.WriteLine("Please enter the package length:");

// Read and convert the package length.
decimal length = Convert.ToDecimal(Console.ReadLine());

// Calculate the total of the package dimensions.
decimal dimensionsTotal = width + height + length;

// Check if the package dimensions exceed 50.
if (dimensionsTotal > 50)
{
    // Display an error message if the package is too big.
    Console.WriteLine("Package too big to be shipped via Package Express.");

    // Stop the program if the package is too big.
    return;
}

// Multiply the height, width, and length together.
decimal volume = height * width * length;

// Calculate the shipping quote by multiplying volume by weight and dividing by 100.
decimal quote = (volume * weight) / 100;

// Display the shipping quote with two decimal places.
Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

// Display a thank-you message.
Console.WriteLine("Thank you!");
