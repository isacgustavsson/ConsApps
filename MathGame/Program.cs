/*
You need to create a Math game containing the 4 basic operations

The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

Users should be presented with a menu to choose an operation

You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

You don't need to record results on a database. Once the program is closed the results will be deleted.

*/
int index = 1;
string name = "isac";
char initial = 'i';
int year = 1994;
decimal height = 1.90m;
bool doWeLoveToCode = true;

string myParagraph = $@"These are the most common data types:
{index} - string, example: {name}
{++index} - char, example: {initial}
{++index} - char, example: {initial}
{++index} - int, example: {year}
{++index} - decimal, height: {height}
{++index} - boolean, doWeLoveToCode: {doWeLoveToCode}";

Console.WriteLine(myParagraph);
Console.ReadLine();
