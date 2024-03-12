namespace Factory
{
    internal class Program
    {
        //Se requiere crear diferentes tipos de muebles, teniendo en cuenta que en cualquier momento se ingresa un mueble nuevo a la coleccion,
        //y se debe poder crear sin modificar lo que ya existe para no afectar la creacion de los muebles que ya se estaba produciendo

        //El factory Method es apropiado para este problema ya que el cliente no necesita saber cómo se crean los objetos,
        //solo trabaja con el cliente y las fabricas concretas. Cuando ingresen nuevos muebles a la coleccion solo sera necesario crearles sus fabricas concretas

        private static void Main()
        {
            FabricaDeMuebles fabrica;

            fabrica = new FabricaDeSillas();
            Console.WriteLine(fabrica.FabricarMueble());

            fabrica = new FabricaDeSofas();
            Console.WriteLine(fabrica.FabricarMueble());

            fabrica = new FabricaDeMesasDeCentro();
            Console.WriteLine(fabrica.FabricarMueble());
        }
    }

    public interface IMueble
    {
        string Descripcion();
    }

    public class Silla : IMueble
    {
        public string Descripcion()
        {
            return "Silla";
        }
    }

    public class Sofa : IMueble
    {
        public string Descripcion()
        {
            return "Sofa";
        }
    }

    public class MesaDeCentro : IMueble
    {
        public string Descripcion()
        {
            return "Mesa de Centro";
        }
    }

    public abstract class FabricaDeMuebles
    {
        public abstract IMueble CrearMueble();

        public string FabricarMueble()
        {
            var mueble = CrearMueble();
            return $"Fabricando...: {mueble.Descripcion()}";
        }
    }

    public class FabricaDeSillas : FabricaDeMuebles
    {
        public override IMueble CrearMueble()
        {
            return new Silla();
        }
    }

    public class FabricaDeSofas : FabricaDeMuebles
    {
        public override IMueble CrearMueble()
        {
            return new Sofa();
        }
    }

    public class FabricaDeMesasDeCentro : FabricaDeMuebles
    {
        public override IMueble CrearMueble()
        {
            return new MesaDeCentro();
        }
    }
}