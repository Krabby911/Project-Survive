public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for(int i = 0; i <= max; i++)
        {
            sum = i + sum;
        }
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        for(int i = 0; i <= max; i++)
        {
            sum = (i*i) + sum;
        }
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}