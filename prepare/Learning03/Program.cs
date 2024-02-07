Fraction fraction1 = new Fraction();
string f1 = fraction1.GetFractionString();
double d1 = fraction1.GetDecimalValue();
Console.WriteLine(f1);
Console.WriteLine(d1);

Fraction fraction2 = new Fraction(5);
string f2 = fraction2.GetFractionString();
double d2 = fraction2.GetDecimalValue();
Console.WriteLine(f2);
Console.WriteLine(d2);

Fraction fraction3 = new Fraction(3, 4);
string f3 = fraction3.GetFractionString();
double d3 = fraction3.GetDecimalValue();
Console.WriteLine(f3);
Console.WriteLine(d3);

Fraction fraction4 = new Fraction(1, 3);
string f4 = fraction4.GetFractionString();
double d4 = fraction4.GetDecimalValue();
Console.WriteLine(f4);
Console.WriteLine(d4);