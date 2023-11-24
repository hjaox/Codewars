namespace CSharp._8kyu;



public class HolidayVISharkPontoon
{
    public static string Shark(
        int pontoonDistance,
        int sharkDistance,
        int youSpeed,
        int sharkSpeed,
        bool dolphin
        )
    {
        if (sharkDistance == 0)
        {
            return "Shark Bait!";
        }
        return youSpeed * sharkDistance * (dolphin ? 2 : 1) < pontoonDistance * sharkSpeed  ? "Shark Bait!" : "Alive!";

    }
}