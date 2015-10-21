using System;

class TheBetterMusicProducer
{
    static void Main()
    {
        decimal europe = decimal.Parse(Console.ReadLine());
        decimal euAlbumPrice = decimal.Parse(Console.ReadLine());

        decimal northAmerica = decimal.Parse(Console.ReadLine());
        decimal naAlbumPrice = decimal.Parse(Console.ReadLine());

        decimal southAmerica = decimal.Parse(Console.ReadLine());
        decimal saAlbumPrice = decimal.Parse(Console.ReadLine());

        decimal numberOfConcerts = decimal.Parse(Console.ReadLine());
        decimal singleConcert = decimal.Parse(Console.ReadLine());

        europe *= euAlbumPrice * 1.94m;
        northAmerica *= naAlbumPrice * 1.72m;
        southAmerica *= saAlbumPrice / 332.74m;

        decimal sumAlbums = europe + northAmerica + southAmerica;
        decimal producerCommission = sumAlbums * 0.35m;
        decimal totalAlbums = (sumAlbums - producerCommission) * 0.80m;

        decimal totalConcerts = numberOfConcerts * singleConcert * 1.94m;
        if (totalConcerts > 100000)
        {
            totalConcerts -= totalConcerts * 0.15m;
        }

        if (totalConcerts < totalAlbums)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F}lv.", totalAlbums);
        }
        else
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F}lv.", totalConcerts);
        }
    }
}
