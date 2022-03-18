// See https://aka.ms/new-console-template for more information
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");

            int angka1;
            int angka2;
            int pilihan;
            int total;

            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("1. penjumlahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");

            Console.WriteLine("Masukkan pilihan menu : ");
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.WriteLine("Masukkan angka pertama : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                total = angka1 + angka2;
                Console.WriteLine("Hasil dari " + angka1 + " + " + angka2 + " = " + total);
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("Masukkan angka pertama : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                total = angka1 - angka2;
                Console.WriteLine("Hasil dari " + angka1 + " - " + angka2 + " = "  + total);
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("Masukkan angka pertama : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                total = angka1 * angka2;
                Console.WriteLine("Hasil dari " + angka1 + " X " + angka2 + " = " + total);
            }
            else if (pilihan == 4)
            {
                Console.WriteLine("Masukkan angka pertama : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                total = angka1 / angka2;
                Console.WriteLine("Hasil dari " + angka1 + " / " + angka2 + " = " + total);
            }else if(pilihan >= 5)
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.ReadLine();
        }
        
    }


