//
//  Returns all the dividers of an number
//
List<int> dividers(int product)
{
    var result = new List<int>();
    var div = 2;
    var remain = product;
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
