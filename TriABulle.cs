/*
Algorithme :

local:   i , j , n, temp Î  Entiers naturels
Entrée : Tab Î  Tableau d'Entiers naturels de 1 à n éléments
Sortie : Tab Î  Tableau d'Entiers naturels de 1 à n éléments

début
 pour i de n jusquà 1 faire // recommence une sous-suite (a1, a2, ... , ai)
  pour j de 2 jusquà i faire // échange des couples non classés de la sous-suite
   si Tab[ j-1 ] > Tab[ j ] alors // aj-1et aj non ordonnés
     temp ¬ Tab[ j-1 ] ;
     Tab[ j-1 ] ¬ Tab[ j ] ;
     Tab[ j ]  ¬ temp //on échange les positions de aj-1et aj
   Fsi
  fpour
 fpour
Fin Tri_a_Bulles

*/



int[] inputArray = { 15, 10, 23, 2, 8, 9, 14, 16 };
var cellCount = inputArray.Length;

for(var i = cellCount-2 ; i>=0 ; i--)
{
    for(j=0 ; j<=i ; j++)
    {
        if(inputArray[j+1] < inputArray[j])
        {
            var t = inputArray[j+1];
            inputArray[j+1] = inputArray[j];
            inputArray[j] = t;
        }
    }
}
