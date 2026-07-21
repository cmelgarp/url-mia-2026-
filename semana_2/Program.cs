
using System.Text.Json; // Libreria para JSON

List<Estudiante> clase = new List<Estudiante>();

string[] rectas = File.ReadAllLines("estudiantes.csv");

for (int i = 1; i < rectas.Length; i++)
{
    string[] informacion = rectas[i].Split(',');

    Estudiante nuevoEstudiante = new Estudiante
    {
        Id = int.Parse(informacion[0]),
        Nombre = informacion[1],
        Carrera = informacion[2]
    };

    clase.Add(nuevoEstudiante);
}

foreach(Estudiante estudiante in clase)
{
        Console.WriteLine(" " + estudiante.Id + " - " + estudiante.Nombre + " - " + estudiante.Carrera);

}

string json = JsonSerializer.Serialize(clase, new JsonSerializerOptions
{
    WriteIndented = true
});

File.WriteAllText("estudiantes.json", json);
