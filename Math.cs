//  Returns all the dividers of an number
//  example : 
//      d(0) : 
//      d(1) : 
//      d(2) : 2 
//      d(3) : 3 
//      d(4) : 2 2 
//      d(5) : 5 
//      d(6) : 2 3 
//      d(7) : 7 
//      d(8) : 2 2 2 
//      d(9) : 3 3 
//
List<int> dividers(int number)
{
    var result = new List<int>();
    var div = 2;
    var remain = number;
    while (remain > 1)
    {
        if ((float)remain/div == remain/div)
        {
            result.Add(div);
            remain = remain/div;
        }
        else
            div++;
    }    
    return result;
}


//  Returns all the divisors of an number
//  example : 
//      d(1) = 1
//      d(2) = 1 2
//      d(3) = 1 3
//      d(4) = 1 2 4
//      d(5) = 1 5
//      d(6) = 1 2 3 6
//      d(7) = 1 7
//      d(8) = 1 2 4 8
//      d(9) = 1 3 9
List<int> divisors(int number)
{
    if (number < 1)
        return new List<int>();
    var result = new List<int>();
    for(var div=1 ; div<number ; div++)
    {
        if (number%div == 0)
        {
            result.Add(div);
        }
    }
    result.Add(number);
    return result;
}
