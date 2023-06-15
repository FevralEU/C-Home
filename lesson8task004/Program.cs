void PrintIndex(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
void Random3DArray(int[,,] array3D)
{
    int count = 10;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[k, i, j] += count;
                count += 3;
            }
        }
    }
}
int[,,] array3D = new int[2, 2, 2];
Random3DArray(array3D);
PrintIndex(array3D); 