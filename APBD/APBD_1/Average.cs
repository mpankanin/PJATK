namespace APBD_1;

public class Average
{

    public Average()
    {
        
    }
    
    public static void Main(string[] args)
    {
        
    }
    
    public static float count(int[] ints)
    {
        float result = 0;
        foreach (var digit in ints)
        {
            result += digit;
        }

        return result/ints.Length;
    }
    
}