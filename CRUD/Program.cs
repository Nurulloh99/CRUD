﻿namespace CRUD
{
    internal class Program
    {


        public static List<string> PhoneNumbers = new List<string>();


        static void Main(string[] arg)
        {
            DeffValue();
            StartPhoneProgram();
        }




        // =================================   F R O N T E N D   =================================

        public static void StartPhoneProgram()
        {
            while (true)
            {
                Console.WriteLine("======<<  CHOOSE ONE OF THEM  >>======");
                Console.WriteLine("1. Enter phone # to list");
                Console.WriteLine("2. Remove phone # from the list");
                Console.WriteLine("3. Update the phone # in list");
                Console.WriteLine("4. Choose if you want to see all phone # in list");
                Console.WriteLine("5. Number that belongs to ...");
                var option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("Enter your # -> ");
                    var number = Console.ReadLine();
                    var index = AddPhoneNumber(number);

                    if (index == -1)
                    {
                        Console.WriteLine("ERROR: This number does not match for all requirements!");
                    }
                    else
                    {
                        Console.WriteLine("Your number has been added successfully !");
                        Console.WriteLine($"Index in list >> {index}");
                    }
                }
                else if (option == 2)
                {
                    Console.Write("Please enter number which you wanna remove from the list >> ");
                    var removingNumber = Console.ReadLine();
                    var resForRemovedNumber = RemoveNUmbers(removingNumber);

                    if (resForRemovedNumber is true)
                    {
                        Console.WriteLine("Choosen number has been DELETED successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Error = 404: Did NOT removed your number");
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter your OLD number >> ");
                    var updatingFirstNumber = Console.ReadLine();
                    Console.Write("Enter your NEW number  >> ");
                    var updatingSecondNumber = Console.ReadLine();
                    var resUpdated = UpdatedNumbers(updatingFirstNumber, updatingSecondNumber);

                    if (resUpdated is true)
                    {
                        Console.WriteLine("Updating proccess has been changed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Error occured 404: Doesn't updated!");
                    }
                }
                else if (option == 4)
                {
                    var FillingOut = GetBackReturn();
                    foreach (var num in FillingOut)
                    {
                        Console.WriteLine(num);
                    }
                }
                else if (option == 5)
                {
                    Console.Write("Please enter number >> ");
                    var countryNumber = Console.ReadLine();
                    CountryCodes(countryNumber);
                }

                Console.ReadKey();
                Console.Clear();
            }

        }









        // =================================   B E C K E N D   =================================

        // Default Value
        public static void DeffValue()
        {
            PhoneNumbers.Add("+998945642165");
            PhoneNumbers.Add("+998978475215");
            PhoneNumbers.Add("+998947564512");
            PhoneNumbers.Add("+14242837985");
            PhoneNumbers.Add("+74568475421");
            PhoneNumbers.Add("+15487541549");
        }


        // Format Elements
        public static bool FormatElements(string checkElements)
        {
            var firstIndex = checkElements[0] == '+';
            var secondIndex = checkElements[1] == '1' || checkElements[1] == '7'
                || checkElements[1] == '9' && checkElements[2] == '9' && checkElements[3] == '8';
            var thirdIndex = checkElements.Count() <= 13 && checkElements.Count() >= 12;

            var trueFalse = false;
            var counter = 0;

            for (var i = 1; i < checkElements.Count(); i++)
            {
                if (Char.IsDigit(checkElements[i]))
                {
                    counter++;
                }
            }

            if (counter == checkElements.Count() - 1)
            {
                trueFalse = true;
            }

            return firstIndex && secondIndex && thirdIndex && trueFalse;
        }


        // Country Codes
        public static void CountryCodes(string codeValur)
        {
            if (codeValur[1] == '1')
            {
                Console.WriteLine("This number of USA ");
            }
            else if (codeValur[1] == '7')
            {
                Console.WriteLine("This number of Russian Federation");
            }
            else if (codeValur[1] == '9' && codeValur[2] == '9' && codeValur[3] == '8')
            {
                Console.WriteLine("This number of Uzbekistan");
            }
            else
            {
                Console.WriteLine("There is no this kind of number anywhere yet or there are some bugs among your codes");
            }
        }


        // Adding Phone Numbers If Not Exist
        public static int AddPhoneNumber(string newPhoneNUmber)
        {
            var exists = PhoneNumbers.Contains(newPhoneNUmber);
            var FormatNumbers = FormatElements(newPhoneNUmber);

            if (exists is true || FormatNumbers is false)
            {
                return -1;
            }

            PhoneNumbers.Add(newPhoneNUmber);
            return PhoneNumbers.Count - 1;
        }


        // Removing Phone Numberes
        public static bool RemoveNUmbers(string deletedValue)
        {
            var checkingNum = PhoneNumbers.Contains(deletedValue);
            PhoneNumbers.Remove(deletedValue);
            return checkingNum;
        }


        // Swaping New Phone NUmbers
        public static bool UpdatedNumbers(string oldNumbers, string newNumbers)
        {
            var index = PhoneNumbers.IndexOf(oldNumbers);
            var trueFalse = false;
            var formatNumbers = FormatElements(newNumbers);

            if (index < 0 || formatNumbers is false)
            {
                return trueFalse;
            }

            PhoneNumbers[index] = newNumbers;
            trueFalse = true;
            return trueFalse;
        }


        // Refilling List
        public static List<string> GetBackReturn()
        {
            return PhoneNumbers;
        }

    }
}
