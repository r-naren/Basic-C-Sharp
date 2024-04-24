using System;
using System.Collections;
using System.Data.Common;
using System.Text.Encodings.Web;
using Microsoft.Win32.SafeHandles;
namespace Demo;
class Program
{
   
    public static void Main(string[] args)
    {

       

        // //Console.Write($"Enter a string : ");
        // string str = "lablablab";
        // //Console.Write($"Enter a substring to search: ");
        // string search = "l";
        // string[] strArray = str.Split(search);
        // Console.WriteLine($"String searched count is {strArray.Length - 1}");

        /*
                //----------------------Anagram----------------------
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                bool isAnagram = true;
                char[] charArr1 = str1.ToCharArray();
                char[] charArr2 = str2.ToCharArray();
                if (charArr1.Length == charArr2.Length)
                {
                    for (int i = 0; i < charArr1.Length ; i++)
                    {
                        for (int j = i; j < charArr1.Length; j++)
                        {
                            if (charArr1[i] > charArr1[j])
                            {
                                char temp = charArr1[i];
                                charArr1[i] = charArr1[j];
                                charArr1[j] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < charArr2.Length ; i++)
                    {
                        for (int j = i; j < charArr2.Length; j++)
                        {
                            if (charArr2[i] > charArr2[j])
                            {
                                char temp = charArr2[i];
                                charArr2[i] = charArr2[j];
                                charArr2[j] = temp;
                            }
                        }
                    }
                    // foreach(char ch in charArr1){
                    //     Console.WriteLine(ch);
                    // }
                    // foreach(char ch in charArr2){
                    //     Console.WriteLine(ch);
                    // }
                    for(int i=0;i<charArr1.Length;i++){
                        if(charArr1[i] != charArr2[i]){
                            isAnagram = false;
                            break;
                        }
                    }
                    if(isAnagram){
                        Console.WriteLine($"Anagram");

                    }
                    else{
                        Console.WriteLine($"Not anagram");

                    }
                }
                else{
                    Console.WriteLine("Not anagram");
                }
                //-----------------------------------------------------------
        */

        /// <summary>
        /// Age calculator
        /// </summary>
        /// <returns></returns>

        /*
                bool temp1 = System.DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime birthday);
                        bool temp2 = System.DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime today);
                        TimeSpan span = today-birthday;
                        int age = span.Days/365;
                        Console.WriteLine($"Age : {age}");
                        Console.WriteLine($"Day : {birthday.DayOfWeek}");
                        Console.WriteLine($"Number of days: {span.Days}");
                        Console.WriteLine($"Number of hourse: {Math.Floor(span.TotalHours)}");
                        Console.WriteLine($"Number of minutes: {Math.Round(span.TotalMinutes)}");
        */

                        

        ///
        /// Removing duplicate character from array
        /// 
        /*

             string str = Console.ReadLine();
             char[] charArray = str.ToCharArray();
             int[] count = new int[str.Length];


             for (int i = 0; i < charArray.Length; i++)
             {

                 for (int j = i; j < charArray.Length; j++)
                 {
                     if (charArray[i] == charArray[j])
                     {
                         count[j] += 1;
                     }
                 }

             }

             string res = "";
             for (int i = 0; i < charArray.Length; i++)
             {
                 if (count[i] == 1)
                 {
                     res += charArray[i];
                 }
             }
             Console.WriteLine(res);

     */

        
        


    }

}
