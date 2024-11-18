namespace CRUD
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

        start:
            Console.WriteLine();
            Console.WriteLine("           << Please select language >> \n");
            Console.WriteLine("     O'zbek tilini tanlash uchun 1 ni bosing");
            Console.WriteLine("     Нажмите 2 для выбора русского языка");
            Console.WriteLine("     Press 3 to select English language");
            Console.WriteLine();
            Console.Write("Select your option >> ");
            var language = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();




            switch (language)
            {
                case 1:


                    while (true)
                    {
                        Console.WriteLine("======<<  RO'YXATDAN BIRINI TANLANG  >>======");
                        Console.WriteLine("  1. Ro'yxatga tel raqamni qo'shish");
                        Console.WriteLine("  2. Ro'yxatdan tel raqamni o'chirish");
                        Console.WriteLine("  3. Ro'yxatdan tel raqamni yangilash");
                        Console.WriteLine("  4. Ro'yxatdagi barcha tel raqamlarni ko'rish");
                        Console.WriteLine("  5. Tel raqamni qayerga tegishli ekanligini bilish ...");
                        Console.WriteLine("  6. Tilni tanlash bo'limiga qaytish");
                        Console.Write("Tanlang >> ");
                        var option = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (option == 1)
                        {
                            Console.Write("Tel raqamingizni kiriting -> ");
                            var number = Console.ReadLine();
                            var index = AddPhoneNumber(number);

                            if (index == -1)
                            {
                                Console.WriteLine("ERROR: Bu tel raqam barcha talablarga to'g'ri kelmaydi!");
                            }
                            else
                            {
                                Console.WriteLine("Sizning tel raqamingiz ro'yxatga muvaffaqqiyatli tarzda qo'shildi !");
                                Console.WriteLine($"Ro'yxatdagi indeksi >> {index}");
                            }
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Iltimos ro'yxatdan o'chirmoqchi bo'lgan tel raqamingizni kiriting");
                            Console.Write("Tel raqam >> ");
                            var removingNumber = Console.ReadLine();
                            var resForRemovedNumber = RemoveNUmbers(removingNumber);

                            if (resForRemovedNumber is true)
                            {
                                Console.WriteLine("Tanlangan tel raqam muvaffaqqiyatli o'chirildi!");
                            }
                            else
                            {
                                Console.WriteLine("Error = 404: Tel raqam o'chmadi, u hali ham mavjud!");
                            }
                        }
                        else if (option == 3)
                        {
                            Console.Write("Iltimos eski tel raqamingizni kiriting >> ");
                            var updatingFirstNumber = Console.ReadLine();
                            Console.Write("Endi esa yangi tel raqamingizni kiriting  >> ");
                            var updatingSecondNumber = Console.ReadLine();
                            var resUpdated = UpdatedNumbers(updatingFirstNumber, updatingSecondNumber);

                            if (resUpdated is true)
                            {
                                Console.WriteLine("O'zgartirish muvaffaqqiyatli tarzda amalga oshirildi!");
                            }
                            else
                            {
                                Console.WriteLine("Error occured 404: O'zgartirilmadi!");
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
                            Console.Write("Iltimos tel raqam kiriting >> ");
                            var countryNumber = Console.ReadLine();
                            CountryCodesInUzbekLang(countryNumber);
                        }
                        else if (option == 6)
                        {
                            goto start;
                        }

                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;

                case 2:

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("======<<  ВЫБЕРИТЕ ОДИН ИЗ НИХ  >>======");
                        Console.WriteLine("  1. Введите телефон # для отображения");
                        Console.WriteLine("  2. Удалить телефон # из списка");
                        Console.WriteLine("  3. Обновление телефона # в списке");
                        Console.WriteLine("  4. Выберите если вы хотите видеть все телефоны # в списке");
                        Console.WriteLine("  5. Номер телефона, который принадлежит...");
                        Console.WriteLine("  6. Вернуться к разделу выбора языка");
                        Console.Write("Выбирать >> ");
                        var option = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (option == 1)
                        {
                            Console.Write("Введите свой номер телефона # -> ");
                            var number = Console.ReadLine();
                            var index = AddPhoneNumber(number);

                            if (index == -1)
                            {
                                Console.WriteLine("ERROR: Этот номер телефона не подходит для всех требований!");
                            }
                            else
                            {
                                Console.WriteLine(" Ваш номер телефона успешно добавлен !");
                                Console.WriteLine($" Индекс в списке >> {index}");
                            }
                        }
                        else if (option == 2)
                        {
                            Console.Write(" Пожалуйста, введите номер телефона, который вы хотите удалить из списка >> ");
                            var removingNumber = Console.ReadLine();
                            var resForRemovedNumber = RemoveNUmbers(removingNumber);

                            if (resForRemovedNumber is true)
                            {
                                Console.WriteLine("Выбранный номер телефона был успешно УДАЛЕН!");
                            }
                            else
                            {
                                Console.WriteLine("Error = 404: НЕ удален ваш номер телефона");
                            }
                        }
                        else if (option == 3)
                        {
                            Console.Write("Введите свой СТАРЫЙ номер телефона >> ");
                            var updatingFirstNumber = Console.ReadLine();
                            Console.Write("Введите свой НОВЫЙ номер телефона  >> ");
                            var updatingSecondNumber = Console.ReadLine();
                            var resUpdated = UpdatedNumbers(updatingFirstNumber, updatingSecondNumber);

                            if (resUpdated is true)
                            {
                                Console.WriteLine(" Процесс обновления успешно изменен!");
                            }
                            else
                            {
                                Console.WriteLine(" Error # 404: Не обновлено!");
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
                            Console.Write("Пожалуйста, введите номер телефона >> ");
                            var countryNumber = Console.ReadLine();
                            CountryCodesInRussianLang(countryNumber);
                        }
                        else if (option == 6)
                        {
                            goto start;
                        }

                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;



                case 3:
                    while (true)
                    {
                        Console.WriteLine("======<<  CHOOSE ONE OF THEM  >>======");
                        Console.WriteLine("  1. Enter phone # to list");
                        Console.WriteLine("  2. Remove phone # from the list");
                        Console.WriteLine("  3. Update the phone # in list");
                        Console.WriteLine("  4. Choose if you want to see all phone # in list");
                        Console.WriteLine("  5. Phone number that belongs to ...");
                        Console.WriteLine("  6. Back to language selection section");
                        Console.Write("Choose >> ");
                        var option = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (option == 1)
                        {
                            Console.Write("Enter your phone # -> ");
                            var number = Console.ReadLine();
                            var index = AddPhoneNumber(number);

                            if (index == -1)
                            {
                                Console.WriteLine("ERROR: This phone number does not match for all requirements!");
                            }
                            else
                            {
                                Console.WriteLine("Your phone number has been added successfully !");
                                Console.WriteLine($"Index in list >> {index}");
                            }
                        }
                        else if (option == 2)
                        {
                            Console.Write("Please enter phone number which you wanna remove from the list >> ");
                            var removingNumber = Console.ReadLine();
                            var resForRemovedNumber = RemoveNUmbers(removingNumber);

                            if (resForRemovedNumber is true)
                            {
                                Console.WriteLine("Choosen phone number has been DELETED successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error = 404: Did NOT removed your phone number");
                            }
                        }
                        else if (option == 3)
                        {
                            Console.Write("Enter your OLD phone number >> ");
                            var updatingFirstNumber = Console.ReadLine();
                            Console.Write("Enter your NEW phone number  >> ");
                            var updatingSecondNumber = Console.ReadLine();
                            var resUpdated = UpdatedNumbers(updatingFirstNumber, updatingSecondNumber);

                            if (resUpdated is true)
                            {
                                Console.WriteLine("Updating proccess has been changed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error occured 404: Not updated!");
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
                            Console.Write("Please enter phone number >> ");
                            var countryNumber = Console.ReadLine();
                            CountryCodes(countryNumber);
                        }
                        else if (option == 6)
                        {
                            goto start;
                        }

                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;
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
        static void CountryCodesInUzbekLang(string codeValur)
        {
            if (codeValur[1] == '1')
            {
                Console.WriteLine("Ushbu telefon raqami AQSh ga tegishli ");
            }
            else if (codeValur[1] == '7')
            {
                Console.WriteLine("Ushbu telefon raqami Rossiya Federatsiyasiga tegishli");
            }
            else if (codeValur[1] == '9' && codeValur[2] == '9' && codeValur[3] == '8')
            {
                Console.WriteLine("Ushbu telefon raqami O'zbekiston ga tegishli");
            }
            else
            {
                Console.WriteLine("Bunday telefon raqami xech qayerda mavjud emas, yoki kodingizda xatolik mavjud!");
            }
        }







        // Country Codes
        static void CountryCodesInRussianLang(string codeValur)
        {
            if (codeValur[1] == '1')
            {
                Console.WriteLine("Этот номер телефона США ");
            }
            else if (codeValur[1] == '7')
            {
                Console.WriteLine("Этот номер телефона Российской Федерации");
            }
            else if (codeValur[1] == '9' && codeValur[2] == '9' && codeValur[3] == '8')
            {
                Console.WriteLine("Этот номер телефона Узбекистана");
            }
            else
            {
                Console.WriteLine("Такого номера телефона еще нигде нет или есть ошибки в ваших кодах");
            }
        }




        // Country Codes
        static void CountryCodes(string codeValur)
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
