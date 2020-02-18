int[][] initializeMatrix(int size)
{
    var result = new int[size][];
    for(var idx=0 ; idx<size ; idx++)
        result[idx] = new int[size];
    return result;
}

void displayMatrix(int[][] m)
{
    for (var i=0 ; i<m.Length ; i++)
    {
        for (var j=0 ; j<m.Length ; j++)
            Console.Write("{0} ", m[i][j]);
        Console.Write("\n");
    }
}

void rotateMatrix90(int[][] input, int[][] output)
{
    var size = input.Length;
    for (var i=0 ; i<size ; i++)
        for (var j=0 ; j<size ; j++)
            output[i][j] = input[size-j-1][i];
}


int[][] rotateMatrix90(int[][] input)
{
    var size = input.Length;
    var output = new int[size][];
    for (var i=0 ; i<size ; i++)
    {
        output[i] = new int[size];
        for (var j=0 ; j<size ; j++)
            output[i][j] = input[size-j-1][i];
    }
    return output;
}

int[][] cloneMatrix(int[][] m)
{
    var output = new int[m.Length][];
    for(var i=0 ; i<m.Length ; i++)
    {
        output[i] = new int[m.Length];
        for(var j=0 ; j<m.Length ; j++)
            output[i][j] = m[i][j];
    }        
    return output;
}
