using System.Numerics;
using ComlexNumber;
Console.WriteLine(" Количество комплексных чисел {0}", ComplexNew.HowMany());
ComplexNew[] a;
ComplexNew d;
a = new ComplexNew[3];
a[0] = new ComplexNew(-1 ,1);
a[1] = new ComplexNew(2, 5);
a[2] = new ComplexNew(3, 0);
Console.WriteLine(" Количество комплексных чисел {0} ", ComplexNew.HowMany());
d = new ComplexNew();
for (int i = 0; i < a.Length; i++)
{
    a[i].PrintComp();
    d = d + a[i];
}
Console.Write(" Сумма равна "); d.PrintComp();
Console.WriteLine(" Модуль суммы равен {0:0.00}", d.Abs());
Console.WriteLine(" Количество комплексных чисел {0}", ComplexNew.HowMany());
Console.ReadKey();
