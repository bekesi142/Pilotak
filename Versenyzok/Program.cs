StreamReader sr = new StreamReader("pilotak.csv");


List<string> neve_lista = new List<string>();
List<string> szuletesi_datum_lista = new List<string>();
List<string> nemzetisege_lista = new List<string>();
List<string> rajtszama_lista = new List<string>();

int hanysorvan = 0;

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    hanysorvan++;
    string nev = sor.Split(",")[0];
    string szuletesi_datum = sor.Split(",")[1];
    string nemzetisege = sor.Split(",")[2];
    string rajtszama = sor.Split(",")[3];
    neve_lista.Add(nev);
    szuletesi_datum_lista.Add(szuletesi_datum);
    nemzetisege_lista.Add(nemzetisege);
    rajtszama_lista.Add(rajtszama);
    string utolsoember = neve_lista[-1];
    Convert.ToInt32(rajtszama);
    int legkisebb_rajtszam = Math.Min(rajtszama_lista.IndexOf);
    string legkisebb_rajtszam_nemzetisege = nemzetisege_lista[legkisebb_rajtszam];
}

Console.WriteLine("3. feladat:  " + hanysorvan);
Console.WriteLine("4. feladat:  " + utolsoember);
Console.WriteLine("6. feladat:  " + legkisebb_rajtszam_nemzetisege);





sr.Close();
