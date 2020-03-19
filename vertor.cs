// NOT TESTED
int[] rotate(int[] pos, int angle)
{
    return new int[] {
        pos[0] * cos(angle) - pos[1] * sin(angle),
        pos[0] * sin(angle) + pos[1] * cos(angle)
    };
}