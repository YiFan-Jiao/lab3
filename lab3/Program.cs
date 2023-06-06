using System.Text;

//question 1
Console.WriteLine("question 1");
List<int> list = new List<int>() { 1, 2, 3, 4, 7, 9, 2, 4 };
HashSet<int> hashList = new HashSet<int>();
List<int> list2 = new List<int>();

foreach (int i in list)
{
    if (!hashList.Add(i))
    {
        list2.Add(i);
    }
}

Console.WriteLine(string.Join(", ", list2));

//question 2
Console.WriteLine("\nquestion 2");
Console.WriteLine("I cant do this in O(n) time.");
List<int> arr1 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> arr2 = new List<int>() { 2, 5, 7, 9, 13 };
List<int> arr3 = new List<int>();

foreach(int i in arr1)
{
    arr3.Add(i);
}

foreach (int i in arr2)
{
    arr3.Add(i);
}

int num = 0;

for (int i = 0; i < arr3.Count - 1; i++)
{
    for(int j = 0; j < arr3.Count - i - 1; j++)
    {
        if (arr3[j] > arr3[j + 1])
        {
            num = arr3[j + 1];
            arr3[j + 1] = arr3[j];
            arr3[j] = num;
        }
    }
}

Console.WriteLine(string.Join(", ", arr3));

//question 3
Console.WriteLine("\nquestion 3");
StringBuilder stringBuilder3 = new StringBuilder();
int number = 3415;
string inputString = number.ToString();
char[] charArray = inputString.ToCharArray();

for (int i = charArray.Length - 1; i >= 0; i--)
{
    stringBuilder3.Append(charArray[i]);
}
Console.WriteLine($"{stringBuilder3},the time complexity is O(n).");



