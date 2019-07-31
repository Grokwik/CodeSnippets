/**
 * Converts any positive number to another base
 */
static string DecimalToXBase(int inputValue, int basex)
{
    var output = "";
    var rem = 0;

    if (0 == inputValue)
        return "0";

    while (inputValue > 0)
    {
        rem = inputValue%basex;
        inputValue = inputValue/basex;
        output = rem + output;
    }
    return output;
}
