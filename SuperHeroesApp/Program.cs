
using System.Text;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Tener super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;


 var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

List<SuperPoder>poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
//opcion 1
//superman.UsarSuperPoderes();
//opcion 2
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);

//clase 
class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

    //constructor 
    public SuperHeroe()
    {
        Id = 1;
       SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }
    //opcion 1
    //public void UsarSuperPoderes()
    //{
    //    foreach(var item in SuperPoderes)
    //    {
    //        Console.WriteLine($"{Nombre} esta usando el super poder {item.Nombre} !! ");
    //    }
    //}
    //opcion 2
    //metodo 
    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in SuperPoderes)
        {
            sb.AppendLine ($"{Nombre} esta usando el super poder {item.Nombre} !! ");
        }
        return sb.ToString();
    }
}
 class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;
    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

