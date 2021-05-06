/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class GuessNumberHigherOrLower
{
    public int Target { get; set; }

    public int GuessNumber(int n)
    {
        var g = n / 2;
        var guessed = false;
        var step = g;
        while (!guessed)
        {
            var result = Guess(g);
            if (result == 0)
            {
                return g;
            }
            step = step / 2;
            if (step < 1)
            {
                step = 1;
            }
            if (result == -1)
            {
                g -= step;
            }
            if (result == 1)
            {
                g += step;
            }
        }
        return 0;
    }

    public int Guess(int num)
    {
        if (num == Target)
        {
            return 0;
        }
        if (num > Target)
        {
            return -1;
        }
        return 1;
    }
}