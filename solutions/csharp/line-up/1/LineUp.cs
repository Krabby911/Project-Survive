public static class LineUp
{
    public static string Format(string name, int number)
    {
        string mname = name;
        int num = number;

        if (number % 100 == 11 || number % 100 == 12 || number % 100 == 13){
    return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }if(num % 10 == 1){
             return $"{mname}, you are the {num}st customer we serve today. Thank you!";   
        }else if(num % 10 == 2){
            return $"{mname}, you are the {num}nd customer we serve today. Thank you!";
        }else if(num % 10 == 3){
            return $"{mname}, you are the {num}rd customer we serve today. Thank you!";
        }else{
            return $"{mname}, you are the {num}th customer we serve today. Thank you!";
        }
    }
}
