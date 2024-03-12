namespace JuegoPrototype
{
    internal class Program
    {
        static void Main()
        {
            //Problema: tenemos un videojuego con 2 tipos de personajes, y cada uno es muy costo de generar por las gráficas
            // y con el patron Prototype solo se crean 1 vez cada uno y luego se clonan, y se modifican
            // las propiedades del clon para hacerlos diferentes
            
            
            Caballero caballeroOriginal = new("Caballero Original", 14, 10);
            Arquero arqueroOriginal = new("Arquero Original", 78, 41);

            Caballero clonCaballero = (Caballero)caballeroOriginal.Clone();
            Arquero clonArquero = (Arquero)arqueroOriginal.Clone();

            clonCaballero.Nombre = "Clon Caballero";
            clonArquero.Nombre = "Clon Arquero";

            Console.WriteLine(caballeroOriginal); 
            Console.WriteLine(clonCaballero); 
            Console.WriteLine(arqueroOriginal); 
            Console.WriteLine(clonArquero); 
        }
    }
}
