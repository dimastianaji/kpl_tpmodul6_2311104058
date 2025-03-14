using tpmodul6_2311104058;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Dimastian Aji Wibowo");

        while (true)
        {
            try
            {
                Console.Write("Masukkan jumlah penambahan play count: ");
                int count = int.Parse(Console.ReadLine());
                video.IncreasePlayCount(count);
                video.PrintVideoDetails();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input harus berupa angka");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Nilai yang dimasukkan terlalu besar!");
            }

            Console.Write("Apakah ingin menambahkan play count lagi? (y/n): ");
            string response = Console.ReadLine().ToLower();
            if (response != "y")
                break;
        }
    }
}
