//
//  Returns all the divisors of an number
//
List<int> divisors(int number)
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
