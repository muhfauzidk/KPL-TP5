using System;

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

        playCount = 0;
        this.title = title;
    }

    public void IncreasePlayCount(int jmlAngka)
    {
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
        string judul = "Tutorial Design By Contract - Muhammad Fauzi Dwikurnia";
        //Create object of class SayaTubeVideo
        SayaTubeVideo p = new SayaTubeVideo(judul);

        p.IncreasePlayCount(1);
        p.PrintVideoDetails();
    }
}