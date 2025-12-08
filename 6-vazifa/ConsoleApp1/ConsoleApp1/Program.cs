//1-masala
// string s = "Hel!lo 2025 @##";
// int letters = 0, digits = 0, others = 0;
//
// for (int i = 0; i < s.Length; i++)
// {
//     char c = s[i];
//
//     if (char.IsLetter(c))
//         letters++;
//     else if (char.IsDigit(c))
//         digits++;
//     else
//         others++;
// }
//
// Console.WriteLine($"Harflar: {letters}");
// Console.WriteLine($"Raqamlar: {digits}");
// Console.WriteLine($"Boshqa: {others}");
//2-masala
// string s = "Hello world this is C#";
// int count = 0;
// bool b = false;
// for (int i = 0; i < s.Length; i++)
// {
//     if (s[i] != ' ' && !b)
//     {
//         count++;
//         b = true;
//     }
//     else if (s[i] == ' ')
//         b = false;
//         
// }
// Console.WriteLine(count);

//
// Console.WriteLine("So'zlar soni: " + count);
//3-masala
// string s = "Hello World";
// int count = 0;
//
// for (int i = 0; i < s.Length; i++)
// {
//     if (char.IsUpper(s[i]))
//     {
//         count++;
//     }
// }
//
// Console.WriteLine($"Stringdagi katta harflar soni: {count}");
//4-masala
// string s = "Hello World";
//
// for (int i = 0; i < s.Length; i++)
// {
//     Console.WriteLine(s[i]);
// }
//5-masala
// string s = "Hello World", result = "", current = "";
//
// for (int i = 0; i < s.Length; i++)
// {
//     if (s[i] != ' ')
//     {
//         current = s[i] + current;
//     }
//     else
//     {
//         result += current + ' ';
//         current = "";
//     }
// }
// result += current;
// Console.WriteLine(result);
//
// result += current;
//
// Console.WriteLine(result);
//6-masala
// string s = "level";
// bool isPal = true;
//
// for (int i = 0; i < s.Length / 2; i++)
// {
//     if (s[i] != s[s.Length - 1 - i])
//     {
//         isPal = false;
//         break;
//     }
// }
//
// Console.WriteLine(isPal);
//7-masala
// string s = "He!!o @2025#", result = "";
//
// for (int i = 0; i < s.Length; i++)
// {
//     if (char.IsLetter(s[i]))
//         result += s[i];
// }
// Console.WriteLine(result);
//8-masala
// string s = "Hello world";
// string vowels = "aeiouAEIOU";
//
// int count = 0;
//
// for (int i = 0; i < s.Length; i++)
// {
//     if (vowels.Contains(s[i]))
//         count++;
// }
//
// Console.WriteLine("Unli harflar: " + count);
//9-masala
// string s = "abracadabrachwdsiujzkbnkjwncbdsjkbxkfeuwdcsauibnwbADSBNIJNBWAJVBWABIJBCUAUECJWAJBSNDKJBKJVBWEKJSDBVKJASBNKJDCASD"; 
// int[] freq = new int[256]; 
//
// for (int i = 0; i < s.Length; i++) 
//     freq[s[i]]++; 
//
// int max = 0; 
// char maxChar = ' '; 
//
// for (int i = 0; i < freq.Length; i++) 
// {
//     if (freq[i] > max) 
//     {
//         max = freq[i]; 
//         maxChar = (char)i; 
//     } 
// } 
//
// Console.WriteLine($"Eng ko'p uchragan belgi: {maxChar} ({max} marta)");
//10-masala
// string s = "hEllo!!! wORLd";
//
// s = s.ToLower();
//
// string result = char.ToUpper(s[0]) + s.Substring(1);
//
// result = result.Replace("!", "")
//     .Replace("@", "")
//     .Replace("#", "")
//     .Replace("$", "")
//     .Replace("%", "")
//     .Replace("^", "")
//     .Replace("&", "")
//     .Replace("*", "")
//     .Replace("(", "")
//     .Replace(")", "");
//
// Console.WriteLine(result);

int[][] matrix = new int[100][];

for (int i = 0; i < matrix.Length; i++)
{
    matrix[i] = new int[i+1];
    for (int j = 1; j < i; j++)
    {
        matrix[i][j] = j + 1;
    }
}

for (int i = 1; i < matrix.Length; i++)
{
    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}

//
// // Declare an array
// string[] cars;
//
// // Add values, using new
// cars = new string[] {"Volvo", "BMW", "Ford"};
// int[] myNumbers = {5, 1, 8, 9};
// Console.WriteLine(myNumbers.Max());  // returns the largest value
// Console.WriteLine(myNumbers.Min());  // returns the smallest value
// Console.WriteLine(myNumbers.Sum());