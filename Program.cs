using System;

public class Program
{
    public static string CalculerRabais(int age, bool membre, double montant, string jour, bool etudiant, int points, bool promo)
    {
        double rabais = 0;

        if (age < 0)
        {
            return "Erreur";
        }

        if (age < 12)
        {
            rabais = 50;
        }
        else if (age < 18)
        {
            rabais = 25;
        }
        else if (age < 65)
        {
            rabais = 0;
        }
        else
        {
            rabais = 30;
        }

        if (membre)
        {
            rabais = rabais + 10;
        }

        if (etudiant)
        {
            rabais = rabais + 5;
        }

        if (promo)
        {
            rabais = rabais + 8;
        }

        if (montant > 200)
        {
            rabais = rabais + 10;
        }
        else if (montant > 100)
        {
            rabais = rabais + 5;
        }
        else if (montant > 50)
        {
            rabais = rabais + 2;
        }

        if (jour == "samedi")
        {
            rabais = rabais + 3;
        }
        else if (jour == "dimanche")
        {
            rabais = rabais + 3;
        }
        else if (jour == "lundi")
        {
            rabais = rabais - 2;
        }

        if (points > 1000)
        {
            rabais = rabais + 7;
        }
        else if (points > 500)
        {
            rabais = rabais + 4;
        }
        else if (points > 100)
        {
            rabais = rabais + 1;
        }

        if (rabais > 60)
        {
            rabais = 60;
        }

        if (montant < 0)
        {
            return "Erreur";
        }

        return "Rabais : " + rabais + " %";
    }

    public static void Main()
    {
        Console.WriteLine(CalculerRabais(20, true, 120, "samedi", false, 600, true));
    }
}
