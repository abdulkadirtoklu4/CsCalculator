namespace CsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dil;

            Console.WriteLine("Dil Seçin / Select Language \n \n TR / EN");

            dil = Console.ReadLine();

            Console.Clear();

            if (dil == "TR" || dil == "Tr" || dil == "tr")
            {

                // İlk Sayıyı Almak.

                Console.WriteLine("İlk Sayıyı Girin: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                // İkinci Sayıyı Almak.
           
                Console.WriteLine("İkini sayıyı Girin: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Yeni Bir Sayı Eklemek İster Misiniz? E / H");
                string sayi = Console.ReadLine();
                Console.Clear();

                if (sayi == "E" || sayi == "e")
                {
                    Console.WriteLine("3. Sayıyı Girin: ");

                    double sayi3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("İşleminizi Seçin: (Toplama(+), Çıkarma(-), Çarpma(-)");

                    string islem = Console.ReadLine();

                    if (islem == "+")
                    {
                        double toplam = sayi1 + sayi2 + sayi3;
                        Console.Clear();

                        Console.WriteLine("Sonucunuz: " + toplam);
                        
                    }

                    else if (islem == "-")
                    {
                        double toplam = sayi1 - sayi2 - sayi3;
                        Console.Clear();

                        Console.WriteLine("Sonucunuz: " + toplam);
                        
                    }

                    else if(islem == "*")
                    {
                        double toplam = sayi1 * sayi2 * sayi3;
                        Console.Clear();

                        Console.WriteLine("Sonucunuz: " + toplam);
                       
                    }

                    
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız.");

                    }
                   
                }
                
                else if(sayi == "H" || sayi == "h")
                {
                    Console.WriteLine("İşlem Seçin: (Toplama, Çıkarma, Çarpma, Bölme, Mod Alma(%))");

                    string islem = Console.ReadLine();

                    if (islem == "+")
                    {
                        double toplam = sayi1 + sayi2;
                        Console.Clear();

                        Console.WriteLine("sonucunuz: " + toplam);
                    }

                    else if (islem == "-")
                    {
                        double toplam = sayi1 - sayi2;
                        Console.Clear();

                        Console.WriteLine("Sonucunuz: " + toplam);
                    }

                    else if (islem == "*")
                    {
                        double toplam = sayi1 * sayi2;
                        Console.Clear();

                        Console.WriteLine("Sonucunuz: " + toplam);
                    }

                    else if (islem == "/")
                    {
                        double toplam = sayi1 / sayi2;
                        Console.Clear();

                        Console.WriteLine("Sonucunuz: " + toplam);
                    }

                    else if (islem == "%")
                    {
                        double toplam = sayi1 % sayi2;
                        Console.Clear();

                        Console.WriteLine("Sonucunuz: " + toplam);
                    }
                }

                Console.ReadKey();
            }

            else if (dil == "EN" || dil == "En"|| dil == "en")
            {
                // Getting The First Issue.

                Console.WriteLine("Enter The First Number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                //  Getting The Second Issue.

                Console.WriteLine("Enter The Second Number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                // Asking the User If They Want to Add Numbers.

                Console.WriteLine("Want to Add a New Number? Y / N");
                string number = Console.ReadLine();

                if (number == "Y" || number == "y")
                {
                    Console.WriteLine("Enter the Third Number: ");

                    double number3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Select Your Trade: (Collection(+), Subtraction(-), Multiplication(-)");

                    string process = Console.ReadLine();

                    if (process == "+")
                    {
                        double total = number1 + number2 + number3;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);

                    }

                    else if (process == "-")
                    {
                        double total = number1 - number2 - number3;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);

                    }

                    else if (process == "*")
                    {
                        double total = number1 * number2 * number3;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);

                    }


                    else
                    {
                        Console.WriteLine("You Pressed the Wrong Key.");

                    }

                }

                else if (number == "N" || number == "n")
                {
                    Console.WriteLine("İşlem Seçin: (Collection(+), Subtraction(-), Multiplication(-), Partition(/), Get Mode(%))");

                    string process = Console.ReadLine();

                    if (process == "+")
                    {
                        double total = number1 + number2;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);
                    }

                    else if (process == "-")
                    {
                        double total = number1 - number2;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);
                    }

                    else if (process == "*")
                    {
                        double total = number1 * number2;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);
                    }

                    else if (process == "/")
                    {
                        double total = number1 / number2;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);
                    }

                    else if (process == "%")
                    {
                        double total = number1 % number2;

                        Console.Clear();

                        Console.WriteLine("Your Conclusion: " + total);
                    }

                    else
                    {
                        Console.WriteLine("You Pressed the Wrong Key.");
                    }

                }

                Console.ReadKey();
           
            }

            else
            {
                Console.Clear();

                Console.WriteLine("Yanlış Tuşa Bastınız. \n You Pressed The Wrong Key.");
            }
        }
    }
}
