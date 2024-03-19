namespace Practice_02;

public class Task03
{
    public static double countAvgChange(int[] arr)
    {
        if (arr == null)
        {
            return 0;
        }
        
        double sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / arr.Length;

    }
}