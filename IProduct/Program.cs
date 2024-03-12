namespace Factory
{
    internal class Program
    {
        static void Main()
        {
            FabricaDeMuebles fabrica;

            fabrica = new FabricaDeSillas();
            Console.WriteLine(fabrica.FabricarMueble());

            fabrica = new FabricaDeSofas();
            Console.WriteLine(fabrica.FabricarMueble());

            fabrica = new FabricaDeMesasDeCafe();
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
            return "Sofá";
        }
    }

    public class MesaDeCafe : IMueble
    {
        public string Descripcion()
        {
            return "Café";
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

    public class FabricaDeMesasDeCafe : FabricaDeMuebles
    {
        public override IMueble CrearMueble()
        {
            return new MesaDeCafe();
        }
    }

}
