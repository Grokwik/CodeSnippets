///////////////////////////////////////////////////////////////////////////////
/// BUILT IN METHOD !!!                                                     ///
///////////////////////////////////////////////////////////////////////////////
Convert.ToString(a, 2);     //  dec to binary (in form of a string)
Convert.ToInt32(result, 2); //  binary (in form of a string) to dec
///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////

/**
 * Converts any positive number to another base
 */
static string DecimalToXBase(int inputValue, int basex)
{
    if (0 == inputValue)
        return "0";

    int rem;
    var output = "";
    while (inputValue > 0)
    {
        rem = inputValue % basex;
        inputValue /= basex;
        if (rem > 10)
        {
            output = (char)('A' + (rem - 10)) + output;
        }
        else
        {
            output = rem + output;
        }
    }
    return output;
}

/// <summary>
/// Converts the given number from the numeral system with the specified
/// radix (in the range [2, 36]) to decimal numeral system.
/// </summary>
/// <param name="number">The arbitrary numeral system number to convert.</param>
/// <param name="radix">The radix of the numeral system the given number
/// is in (in the range [2, 36]).</param>
/// <returns></returns>
// From https://www.pvladov.com/2012/07/arbitrary-to-decimal-numeral-system.html
public static long ArbitraryToDecimalSystem(string number, int radix)
{
    const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    if (radix < 2 || radix > Digits.Length)
        throw new ArgumentException("The radix must be >= 2 and <= " +
            Digits.Length.ToString());

    if (String.IsNullOrEmpty(number))
        return 0;

    // Make sure the arbitrary numeral system number is in upper case
    number = number.ToUpperInvariant();

    long result = 0;
    long multiplier = 1;
    for (int i = number.Length - 1; i >= 0; i--)
    {
        char c = number[i];
        if (i == 0 && c == '-')
        {
            // This is the negative sign symbol
            result = -result;
            break;
        }

        int digit = Digits.IndexOf(c);
        if (digit == -1)
            throw new ArgumentException(
                "Invalid character in the arbitrary numeral system number",
                "number");

        result += digit * multiplier;
        multiplier *= radix;
    }

    return result;
}
