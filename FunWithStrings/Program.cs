// See https://aka.ms/new-console-template for more information

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