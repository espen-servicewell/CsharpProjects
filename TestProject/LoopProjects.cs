/*string? readResult;
int numericValue = 0;
bool validNumber = false;
bool acceptedValue = false;

do {
    Console.WriteLine("Enter an integer between 5 and 10:");
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (readResult != null) {
        if (validNumber) {
            if (numericValue >= 5 && numericValue <= 10) {
                Console.WriteLine($"Your input value ({numericValue}) has been accepted");
                acceptedValue = true;
            }
            else {
                Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            }
        }
        else {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    }

} while (!acceptedValue);
*/

/*string? readResult;
bool acceptedValue = false;

do {
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine().Trim().ToLower();
    if (readResult.Contains("administrator") || readResult.Contains("manager") || readResult.Contains("user")) {
        Console.WriteLine($"Your input value {readResult} has been accepted.");
        acceptedValue = true;
    }
    else {
        Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (!acceptedValue);*/

using System.Diagnostics.Metrics;

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++) {
    string myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    string mySentence;

    while (periodLocation != -1) {
        mySentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1).TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}