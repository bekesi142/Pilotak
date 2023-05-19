StreamReader sr = new StreamReader("pilotak.csv");


List<string> neve_lista = new List<string>();
List<string> szuletesi_datum_lista = new List<string>();
List<string> nemzetisege_lista = new List<string>();
List<string> rajtszama_lista = new List<string>();


while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    string nev = sor.Split(",")[0];
    string szuletesi_datum = sor.Split(",")[1];
    string nemzetisege = sor.Split(",")[2];
    string rajtszama = sor.Split(",")[3];
    neve_lista.Add(nev);
    szuletesi_datum_lista.Add(szuletesi_datum);
    nemzetisege_lista.Add(nemzetisege);
    rajtszama_lista.Add(rajtszama);
}






sr.Close();
