int[] inputArray = { 15, 10, 23, 2, 8, 9, 14, 16 };
var cellCount = inputArray.Length;

for(var i=cellCount-2 ; i>=0 ; i--)
{
    for(var j=0 ; j<=i ; j++)
    {
        if(inputArray[j+1] < inputArray[j])
        {
            var t = inputArray[j+1];
            inputArray[j+1] = inputArray[j];
            inputArray[j] = t;
        }
    }
}
