using tpmodul6_2311104058;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Dimastian Aji Wibowo");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}
