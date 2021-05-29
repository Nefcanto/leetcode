public class OneBitAndTwoBitCharacters
{
    public bool IsOneBitCharacter(int[] bits)
    {
        int? last = null;
        for (int i = 0; i < bits.Length; i++)
        {
            if (last.HasValue)
            {
                if (last == 1)
                {
                    last = null;
                }
                else
                {
                    last = bits[i];
                }
            }
            else
            {
                last = bits[i];
            }
        }
        if (last.HasValue)
        {
            return true;
        }
        return false;
    }
}