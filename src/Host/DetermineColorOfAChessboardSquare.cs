using System;

public class DetermineColorOfAChessboardSquare
{
    public bool SquareIsWhite(string coordinates)
    {
        var letter = coordinates[0];
        var number = Convert.ToInt16(coordinates[1].ToString());
        if (letter == 'a' || letter == 'c' || letter == 'e' || letter == 'g')
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        else
        {
            if (number % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }

    public bool SquareIsWhiteWithOptimization(string coordinates)
    {
        var letter = coordinates[0].ToString();
        var number = Convert.ToInt16(coordinates[1].ToString());
        if ("aceg".Contains(letter))
        {
            number++;
        }
        if (number % 2 == 1)
        {
            return true;
        }
        return false;
    }
}