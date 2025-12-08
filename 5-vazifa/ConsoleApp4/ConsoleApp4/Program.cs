using System;

class Program
{
    static void Main()
    {
        double listening = GetScore("Listening");
        double reading = GetScore("Reading");
        double writing = GetScore("Writing");
        double speaking = GetScore("Speaking");

        double finalScore = CalculateFinalScore(listening, reading, writing, speaking);
        string category = GetCategory(finalScore);

        Console.WriteLine($"Final IELTS Score: {finalScore}");
        Console.WriteLine($"Category: {category}");
    }

    static double GetScore(string skill)
    {
        Console.Write($"{skill}: ");
        return double.Parse(Console.ReadLine());
    }

    static double CalculateFinalScore(double l, double r, double w, double s)
    {
        double average = (l + r + w + s) / 4.0;
        double floor = Math.Floor(average);
        double different = average - floor;

        if (different < 0.25)
            return floor;
        else if (different < 0.75)
            return floor + 0.5;
        else
            return floor + 1;
    }

    static string GetCategory(double score)
    {
        if (score == 9) 
            return "Expert";
        else if (score >= 8 && score < 9) 
            return "Very Good";
        else if (score >= 7 && score < 8) 
            return "Good";
        else if (score >= 6 && score < 7) 
            return "Competent";
        else if (score >= 5 && score < 6) 
            return "Modest";
        else 
            return "Invalid score range";
    }
}