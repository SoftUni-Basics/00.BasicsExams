using System;

class TheBetterMusicProducer
{
    static void Main()
    {
        decimal europe = decimal.Parse(Console.ReadLine());
        decimal euAlbumPrice = decimal.Parse(Console.ReadLine());   //  price in euro   -   1 euro is 1.94lv.
        
        decimal northAmerica = decimal.Parse(Console.ReadLine());
        decimal naAlbumPrice = decimal.Parse(Console.ReadLine());   //  dollars         -   1 dollar is 1.72lv.
        
        decimal southAmerica = decimal.Parse(Console.ReadLine());
        decimal saAlbumPrice = decimal.Parse(Console.ReadLine());   // pesos            -   332.74 pesos are 1lv.
        
        decimal numberOfConcerts = decimal.Parse(Console.ReadLine());
        decimal singleConcert = decimal.Parse(Console.ReadLine());   // euro            -   1 euro is 1.94lv.
        
        europe *= euAlbumPrice * 1.94m;
        northAmerica *= naAlbumPrice * 1.72m;
        southAmerica *= saAlbumPrice / 332.74m;

        decimal sumAlbums = europe + northAmerica + southAmerica;
        decimal producerCommission = sumAlbums * 0.35m;
        decimal totalAlbums = (sumAlbums - producerCommission) * 0.80m; // -20% other taxes

        decimal totalConcerts = numberOfConcerts * singleConcert * 1.94m;
        if (totalConcerts > 100000)
        {
            totalConcerts -= totalConcerts * 0.15m;
        }

        if (totalConcerts < totalAlbums)
        {
            /*If the total profit from all album is more than from all concerts print on the console:
                “Let’s record some songs! They’ll bring us {incomes from albums}lv.”
             */
            Console.WriteLine("Let’s record some songs! They’ll bring us {0:F}lv.", totalAlbums);
        }
        else
        {
            /*
            If it is equal to or the profit from the concerts is greater:
                “On the road again! We’ll see the world and earn {profit from concerts}lv.”*/
            Console.WriteLine("On the road again! We’ll see the world and earn {0:F}lv.", totalConcerts);
        }
    }
}
