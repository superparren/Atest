class Program
{
static void Main(string[] args)
{
string[] inputArray = { "Hello", "2", "world", ":-)" };
string[] newArray = FilterArray(inputArray);
Console.WriteLine(string.Join(", ", newArray));
}
static string[] FilterArray(string[] inputArray)
{
int count = 0;
for (int i = 0; i < inputArray.Length; i++)
{
if (inputArray[i].Length <= 3)
{
count++;
}
}
string[] newArray = new string[count];
int index = 0;
for (int i = 0; i < inputArray.Length; i++)
{
if (inputArray[i].Length <= 3)
{
newArray[index] = inputArray[i];
index++;
}
}
return newArray;
}
}