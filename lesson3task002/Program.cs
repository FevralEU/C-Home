Console.Clear();
Console.WriteLine("Введите для точки А х:");
int numAx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки А y:");
int numAy = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки A z:");
int numAz = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки B х:");
int numBx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки B y:");
int numBy = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки B z:");
int numBz = int.Parse(Console.ReadLine());

double answer = Pifa(numAx, numAy, numAz, numBx, numBy, numBz);
double finAnswer = Math.Round(answer, 2, MidpointRounding.ToZero);
Console.WriteLine(finAnswer);

double Pifa(int nAx, int nAy, int nAz, int nBx, int nBy, int nBz)
{
int cat1 = nAx - nBx;
int cat2 = nAy - nBy;
int cat3 = nAz - nBz;
double gypo = Math.Sqrt( (cat1*cat1) + (cat2*cat2) + (cat3*cat3));
return gypo;
}