StreamReader sr = new StreamReader("pilotak.csv");


List<string> neve = new List<string>();
List<string> szuletesi_datum = new List<string>();
List<string> nemzetisege = new List<string>();
List<int> rajtszama = new List<int>();


while (!sr.EndOfStream)
{
    string nev = sr.ReadLine();
}