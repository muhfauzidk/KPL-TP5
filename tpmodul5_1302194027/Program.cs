using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        //Generate 5 digit random number
        Random r = new Random();
        this.id = r.Next(100000);
        string fiveDigit = this.id.ToString("D5");

        //DbC preconditions
        Contract.Requires(title != null && title.Length <= 100);

        playCount = 0;
        this.title = title;       
    }

    public void IncreasePlayCount(int jmlAngka)
    {
        //DbC preconditions
        Contract.Requires(jmlAngka <= 10000000);

        //Exception
        try
        {
            checked
            {
                jmlAngka += 1;
            }
        } catch (OverflowException e) {
            Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
        }

        this.playCount = jmlAngka;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("id: " + this.id);
        Console.WriteLine("title: " + this.title);
        Console.WriteLine("play count: " + this.playCount);
    }

    public static void Main()
    {
        string judul = null;
        //Create object of class SayaTubeVideo
        SayaTubeVideo p = new SayaTubeVideo(judul);

        p.IncreasePlayCount(0);
        p.PrintVideoDetails();
    }
}