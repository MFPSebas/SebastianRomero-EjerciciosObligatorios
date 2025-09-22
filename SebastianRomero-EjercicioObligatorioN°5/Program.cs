using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianRomero_EjercicioObligatorioN_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instancia[] maquinas =
{
                new ProcesoDatos("Proc1", "1.0", "Linux", "db_origen", "db_destino"),
                new ProcesoDatos("Proc2", "1.1", "Linux", "db_origen2", "db_destino2"),
                new Aplicacion("App1", "1.0", "Windows", "Java", "17", "jdbc://db1"),
                new Aplicacion("App2", "1.0", "Windows", "Python", "3.11", "jdbc://db2")
            };

            foreach (var vm in maquinas)
            {
                string resultado = vm.Levantar();
                Console.WriteLine(resultado);
            }
        }
    }
    public abstract class Instancia
    {
        protected string Nombre;
        protected string Version;
        protected string SistemaOp;
        protected Estado estado;

        public Instancia() { }

        public Instancia(string nombre, string version, string sistemaOp)
        {
            this.Nombre = nombre;
            this.Version = version;
            this.SistemaOp = sistemaOp;
            estado = Estado.Down;
        }

        public abstract string Levantar();

        public virtual string Bajar()
        {
            return $"\n***************Sesion incorrecta para {this.Nombre}******************\n";
        }

        public void VerEstado() { }
    }
    public enum Estado
    {
        Up, Down
    }

    class ProcesoDatos : Instancia
    {
        string datosOrigen;
        string datosFin;

        public ProcesoDatos() { }

        public ProcesoDatos(string nombre, string version, string sistemaOp, string Origen, string Fin) : base(nombre, version, sistemaOp)
        {
            this.datosOrigen = Origen;
            this.datosFin = Fin;
        }

        public void ClonarBaseDatos()
        {
            Console.WriteLine("\tLISTO");
        }

        public void FiltrarDatos()
        {
            Console.WriteLine("\tFiltrando..");
        }

        public void AlmacenarDatos()
        {
            Console.WriteLine("\tAlmacenado!");
        }

        public override string Levantar()
        {
            if (datosOrigen == "db_origen" && datosFin == "db_destino")
            {
                Console.WriteLine($"Datos correctos...Levantando el estado.. para {this.Nombre}");
                this.estado = Estado.Up;
                Console.WriteLine("\tSesion correcta");
                Console.WriteLine("Clonando base de datos..");
                ClonarBaseDatos();
                Console.WriteLine("Filtrar datos?");
                string resp = Console.ReadLine();
                if (resp.ToLower() == "si")
                {
                    FiltrarDatos();
                }
                Console.WriteLine("almacenando datos..");
                AlmacenarDatos();
                return "Todo correcto! cerrando sesión";
            }
            else
                return Bajar();
        }
    }

    class Aplicacion : Instancia
    {
        string LenguajeProg;
        string VersionLeng;
        string BaseDat;

        public Aplicacion() { }

        public Aplicacion(string nombre, string version, string sistemaOp, string Lenguaje, string VersionLeng, string BaseDat) : base(nombre, version, sistemaOp)
        {
            this.LenguajeProg = Lenguaje;
            this.VersionLeng = VersionLeng;
            this.BaseDat = BaseDat;
        }
        public override string Levantar()
        {
            string Lenguaje = VerificarLenguaje();
            string basedatos = VerificarBaseDatos();
            if (Lenguaje == "coincide" && basedatos == "coincide")
            {
                Console.WriteLine($"Datos correctos...Levantando el estado.. para {this.Nombre}");
                this.estado = Estado.Up;
                Console.WriteLine("Sesion correcta");
                return $"Sesion Iniciada para {this.Nombre}!";
            }
            else
                return Bajar();
        }

        public string VerificarLenguaje()
        {
            if (LenguajeProg == "Java")
                return "coincide";
            else
                return "No coincide";
        }

        public string VerificarBaseDatos()
        {
            if (BaseDat == "jdbc://db1")
                return ("coincide");
            else
                return "No coincide";
        }
    }
}
