using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Pipes;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Sources;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SebastianRomero_EjercicioObligatorioN_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                            1
            /*double[] latitudes = { -141.23, 124.5, 151.3, -432.21, -312.33 };
            double[] longitudes = { 221.4,123.3, 4123.5, 12, 312.15 };

            int d = 5; // offset / diferencia de posiciones

            // Mostrar emparejamientos según la regla latitud[i] -> longitud[(i + d) % n]
            int n = latitudes.Length;
            Console.WriteLine($"Offset d = {d}\n");
            for (int i = 0; i < n; i++)
            {
                int j = (i + d) % n; // índice de longitud correspondiente
                Console.WriteLine($"latitud[{i}] = {latitudes[i]}  <-->  longitud[{j + 5}] = {longitudes[j]}");
            }

            // Ejemplo: recuperar la coordenada "real" (lat,long) de la entrada i = 0
            int index = 0;
            int longitudIndex = (index + d) % n;
            Console.WriteLine($"\nPar para index {index}: ({latitudes[index]}, {longitudes[longitudIndex]})");*/

            //                             2

            /*Console.WriteLine("¿Desea ingresar un nuevo vehiculo?");
            string RespNew = Console.ReadLine() ?? "no";
            do
            {
                switch (RespNew.ToLower())
                {
                    case "si":
                        Console.WriteLine("¿Que vehiculo desea ingresar? (Moto/Auto/Camioneta) \n Pulse enter sin responder para finalizar");
                        string RespVeh = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(RespVeh))
                            RespVeh = "ninguno";
                        switch (RespVeh.ToLower())
                        {
                            case "moto":
                                Console.WriteLine("ingrese marca, modelo, año y tipo de manubrio (uno debajo del otro en ese orden)");
                                string marcaMoto = Console.ReadLine() ?? "no tiene";
                                string modeloMoto = Console.ReadLine() ?? "no tiene";
                                int anioMoto = int.Parse(Console.ReadLine());
                                string tipo_Manubrio = Console.ReadLine() ?? "null";
                                Moto moto = new Moto(marcaMoto, modeloMoto, anioMoto, tipo_Manubrio);
                                Console.WriteLine("Moto creada correctamente");
                                moto.MostrarinformacionMoto();
                                break;
                            case "Auto":
                                bool esAutomatico;
                                Console.WriteLine("ingrese marca, modelo, año , cantidad de puertas y (si/no) es automatico, uno debajo del otro en ese orden.");
                                string marcaAuto = Console.ReadLine() ?? "no tiene";
                                string modeloAuto = Console.ReadLine() ?? "no tiene";
                                int anioAuto = int.Parse(Console.ReadLine());
                                int cantidadDePuertasAuto = int.Parse(Console.ReadLine());
                                string RespAut = Console.ReadLine();
                                if (RespAut == "si")
                                {
                                    esAutomatico = true;
                                }
                                else
                                {
                                    esAutomatico = false;
                                }
                                Auto Auto = new Auto(marcaAuto, modeloAuto, anioAuto, cantidadDePuertasAuto, esAutomatico);
                                Console.WriteLine("Auto creado correctamente");
                                Auto.MostrarinformacionAuto();
                                break;
                            case "camioneta":
                                bool es4x4;
                                Console.WriteLine("ingrese marca, modelo, año , cantidad de puertas y (si/no) es 4x4, uno debajo del otro en ese orden.");
                                string marcaCamioneta = Console.ReadLine() ?? "no tiene";
                                string modeloCamioneta = Console.ReadLine() ?? "no tiene";
                                int anioCamioneta = int.Parse(Console.ReadLine());
                                int cantidadDePuertasCamioneta = int.Parse(Console.ReadLine());
                                string RespCamioneta = Console.ReadLine();
                                if (RespCamioneta == "si")
                                {
                                    es4x4 = true;
                                }
                                else
                                {
                                    es4x4 = false;
                                }
                                Camioneta camioneta = new Camioneta(marcaCamioneta, modeloCamioneta, anioCamioneta, cantidadDePuertasCamioneta, es4x4);
                                Console.WriteLine("\n \n Camioneta creada correctamente");
                                camioneta.MostrarinformacionCamioneta();
                                break;
                            case "ninguno":
                                RespNew = "no";
                                Console.WriteLine("Cerrando proceso");
                                break;
                            default:
                                break;
                        }
                        if (RespNew == "no")
                            break;
                        break;
                    case "no":
                        Console.WriteLine("Cerrando proceso");
                        break;
                }
                if (RespNew == "no")
                    break;
                Console.WriteLine("¿Desea ingresar un nuevo vehiculo?");
                RespNew = Console.ReadLine() ?? "no";
            } while (RespNew != "no");*/


            /*                             3
            Console.WriteLine("¿Desea crear una persona?");
            string RespPer = Console.ReadLine() ?? " ";
            if (string.IsNullOrWhiteSpace(RespPer))
                RespPer = "no";
            do
            {
                switch (RespPer)
                {
                    case "si":
                        Console.WriteLine("Ingrese su nombre, edad y DNI en ese orden \n *RECUERDE QUE SIN DNI NO PUEDE ASIGNAR VEHICULO*");
                        string nombre = Console.ReadLine() ?? "no tiene";
                        int? edad = int.Parse(Console.ReadLine() ?? string.Empty);
                        int? DNI = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (DNI == null)
                        {
                            Persona personaSinDNI = new Persona(nombre, edad);
                        }
                        else
                        {
                            Persona persona = new Persona(nombre, edad, DNI);
                            persona.MostrarinformacionPersona(nombre, edad, DNI);
                            Console.WriteLine("¿Desea asociar un vehiculo?");
                            string RespUsVeh = Console.ReadLine() ?? "no";
                            if (RespUsVeh.ToLower() == "si")
                            {
                                persona.vehiculopropio = Vehiculo.CrearVehiculoInteractivo();
                                break;
                            }
                        }
                        break;
                    case "no":
                        Console.WriteLine("Cerrando app");
                        break;
                }
            } while (RespPer != "no");
            */
            /*                           4
            Console.WriteLine("¿desea crear un jugador o tecnico?");
            string RespJot = Console.ReadLine() ?? " ";
            do
            {
                switch (RespJot)
                {
                    case "jugador":
                        Console.WriteLine("ingrese nombre, apellido, edad, antiguedad y posicion (uno debajo de la otra)");
                        string nombreJug = Console.ReadLine() ?? "no tiene";
                        string ApellidoJug = Console.ReadLine() ?? "no especificado";
                        int edad = int.Parse(Console.ReadLine());
                        int antiguedad = int.Parse(Console.ReadLine());
                        string pos = Console.ReadLine() ?? "a probar";
                        Jugador jugador = new Jugador(nombreJug, ApellidoJug, edad, antiguedad, pos);
                        Console.WriteLine("Agregue detalles del cotnrato");
                        int DuracionContrato = Integrante.Contrato();
                        if (DuracionContrato <= 1)
                        {
                            Console.WriteLine("¿desea saber si va a renovar?");
                            string RespRen = Console.ReadLine() ?? "no";
                            if (RespRen.ToLower() == "si")
                            {
                                jugador.Renovo();
                            }
                        }
                        Console.WriteLine("INFORMACION:\n");
                        jugador.Mostrarinformacion();
                        break;
                    case "tecnico":
                        Console.WriteLine("ingrese nombre, apellido, edad, antiguedad y especialidad (uno debajo de la otra)");
                        string nombreTec = Console.ReadLine() ?? "no tiene";
                        string ApellidoTec = Console.ReadLine() ?? "no especificado";
                        int edadTec = int.Parse(Console.ReadLine());
                        int antiguedadTec = int.Parse(Console.ReadLine());
                        string espec = Console.ReadLine() ?? "no tiene/no sabe";
                        Tecnico tecnico = new Tecnico(nombreTec, ApellidoTec, edadTec, antiguedadTec, espec);
                        Console.WriteLine("Agregue detalles del cotnrato");
                        int DuracionContratoTec = Integrante.Contrato();
                        if (DuracionContratoTec <= 1)
                        {
                            Console.WriteLine("¿desea saber si va a renovar?");
                            string RespRen = Console.ReadLine() ?? "no";
                            if (RespRen.ToLower() == "si")
                            {
                                tecnico.Renovo();
                            }
                        }
                        Console.WriteLine("INFORMACION:\n");
                        tecnico.Mostrarinformacion();
                        break;
                    default:
                        Console.WriteLine("error, intente de nuevo");
                        break;
                }

            } while (RespJot != " ");
            */
            Pokemon[] pokemon = new Pokemon[3];
            pokemon[0] = new PokemonAgua();
            pokemon[1] = new PokemonFuego();
            pokemon[2] = new PokemonElectrico();
            string pokemonencontrado;
            Console.WriteLine("¿Que pokemon llevas? \n AGUA \t FUEGO \t ELECTRICO");
            string eleccion = Console.ReadLine() ?? " ";
            switch (eleccion)
            {
                case "agua":
                    Console.WriteLine("¿Que nombre le queres poner?");
                    string nombreAg = Console.ReadLine() ?? "Generico";
                    Console.WriteLine("Su nivel es:\n");
                    int nivelAg = int.Parse(Console.ReadLine());
                    pokemonencontrado = pokemon[0].Rival();
                    Console.WriteLine($"tu pokemon {nombreAg} de nivel {nivelAg} se dispone a atacar al pokemon tipo {pokemonencontrado}");
                    Console.WriteLine("¿deseas atacar?");
                    string RespAg = Console.ReadLine() ?? "no";
                    if (RespAg.ToLower() == "si")
                    {
                        pokemon[0].Atacar(eleccion,pokemonencontrado,pokemon);
                    }
                    break;
                case "fuego":
                    Console.WriteLine("¿Que nombre le queres poner?");
                    string nombreFue = Console.ReadLine() ?? "Generico";
                    Console.WriteLine("Su nivel es:\n");
                    int nivelFue = int.Parse(Console.ReadLine());
                    pokemonencontrado = pokemon[1].Rival();
                    Console.WriteLine($"tu pokemon {nombreFue} de nivel {nivelFue} se dispone a atacar al pokemon tipo {pokemonencontrado}");
                    Console.WriteLine("¿deseas atacar?");
                    string RespFue = Console.ReadLine() ?? "no";
                    if (RespFue.ToLower() == "si")
                    {
                        pokemon[1].Atacar(eleccion,pokemonencontrado,pokemon);
                    }
                    break;
                case "electrico":
                    Console.WriteLine("¿Que nombre le queres poner?");
                    string nombreEle = Console.ReadLine() ?? "Generico";
                    Console.WriteLine("Su nivel es:\n");
                    int nivelEle = int.Parse(Console.ReadLine());
                    pokemonencontrado = pokemon[2].Rival();
                    Console.WriteLine($"tu pokemon {nombreEle} de nivel {nivelEle} se dispone a atacar al pokemon tipo {pokemonencontrado}");
                    Console.WriteLine("¿deseas atacar?");
                    string RespEle = Console.ReadLine() ?? "no";
                    if (RespEle.ToLower() == "si")
                    {
                        pokemon[2].Atacar(eleccion,pokemonencontrado,pokemon);
                    }
                    break;
                default:
                    Console.WriteLine("error,intente de nuevo");
                    break;
            }


        }
    }
    class Vehiculo
    {
        protected string marca { get; set; }
        protected string modelo { get; set; }
        protected int anio { get; set; }
        public void CambiarMarcha()
        {
            Console.WriteLine("Se ha cambiado a la siguiente marcha");
        }

        public void Mostrarinformacion()
        {

        }
        public Vehiculo()
        {

        }
        public static Vehiculo CrearVehiculoInteractivo()
        {
            string RespVehPer;
            do
            {
                Console.WriteLine("¿Que vehiculo tiene? Auto/Moto/Camioneta \n Enter para terminar");
                RespVehPer = Console.ReadLine() ?? " ";
                switch (RespVehPer.ToLower())
                {
                    case "auto":
                        return new Auto();
                    case "moto":
                        return new Moto();
                    case "camioneta":
                        return new Camioneta();
                    case "":
                    case " ":
                        return null;
                    default:
                        Console.WriteLine("Incorrecto, intente de nuevo");
                        break;
                }
            } while (true);
        }
    }

    class Auto : Vehiculo
    {
        int cantidadDePuertas { get; set; }
        bool esAutomatico { get; set; }

        public void MostrarinformacionAuto()
        {
            Console.WriteLine($" su auto es de la marca:\n {marca} \n modelo:\n {modelo} \n año:\n {anio} \n cambios automaticos:\n {esAutomatico} \n Puertas:\n {cantidadDePuertas}");
        }

        public void CambiarMarchaAuto()
        {
            Console.WriteLine("Se ha cambiado el auto a la siguiente marcha");
        }

        public Auto()
        {
            bool esAutomatico;
            Console.WriteLine("ingrese marca, modelo, año, cantidad de puertas y (si/no) es automatico, uno debajo del otro en ese orden");
            string marcaAuto = Console.ReadLine() ?? "no registrado";
            string modeloAuto = Console.ReadLine() ?? "no especificado";
            int anioAuto = int.Parse(Console.ReadLine());
            int cantidadDePuertas = int.Parse(Console.ReadLine());
            string RespAutomatic = Console.ReadLine() ?? "no";
            this.marca = marcaAuto;
            this.modelo = modeloAuto;
            this.anio = anioAuto;
            this.cantidadDePuertas = cantidadDePuertas;
            if (RespAutomatic.ToLower() == "si")
                esAutomatico = true;
            else
                esAutomatico = false;
            this.esAutomatico = esAutomatico;
            MostrarinformacionAuto();
        }
        public Auto(string marcaAuto, string modeloAuto, int anioAuto, int cantidadDePuertasAuto, bool esAutomatico)
        {
            this.marca = marcaAuto;
            this.modelo = modeloAuto;
            this.anio = anioAuto;
            this.cantidadDePuertas = cantidadDePuertasAuto;
            this.esAutomatico = esAutomatico;
        }
    }

    class Moto : Vehiculo
    {
        string tipoManubrio { get; set; }

        public void MostrarinformacionMoto()
        {
            Console.WriteLine($"es de la marca: {marca} \n modelo: {modelo} \n año: {anio} \n Tipo de manubrio: {tipoManubrio}");
        }

        public void CambiarMarchaMoto()
        {
            Console.WriteLine("Se ha cambiado la moto a la siguiente marcha");
        }

        public Moto()
        {
            Console.WriteLine("ingrese marca, modelo, año, tipo de manubrio, uno debajo del otro en ese orden");
            string marcaMoto = Console.ReadLine() ?? "no registrado";
            string modeloMoto = Console.ReadLine() ?? "no especificado";
            int anioMoto = int.Parse(Console.ReadLine());
            string tipoManubrio = Console.ReadLine() ?? "no sabe";
            this.marca = marcaMoto;
            this.modelo = modeloMoto;
            this.anio = anioMoto;
            this.tipoManubrio = tipoManubrio;
            MostrarinformacionMoto();
        }
        public Moto(string marcaMoto, string modeloMoto, int anioMoto, string tipo_Manubrio)
        {
            this.marca = marcaMoto;
            this.modelo = modeloMoto;
            this.anio = anioMoto;
            this.tipoManubrio = tipo_Manubrio;
        }
    }

    class Camioneta : Vehiculo
    {
        int cantidadDePuertas { get; set; }
        bool es4x4 { get; set; }

        public void MostrarinformacionCamioneta()
        {
            Console.WriteLine($"es de la marca: {marca} \n modelo: {modelo} \n año: {anio} \n cantidad de puertas: {cantidadDePuertas} \n es 4x4: {es4x4}");
        }

        public void CambiarMarchaCamioneta()
        {
            Console.WriteLine("Se ha cambiado la camioneta a la siguiente marcha");
        }

        public Camioneta()
        {
            Console.WriteLine("ingrese marca, modelo, año, cantidad de puertas, (si/no) es 4x4, uno debajo del otro en ese orden");
            string marcaCamioneta = Console.ReadLine() ?? "no registrado";
            string modeloCamioneta = Console.ReadLine() ?? "no especificado";
            int anioCamioneta = int.Parse(Console.ReadLine());
            int CantidadDePuertas = int.Parse(Console.ReadLine());
            this.marca = marcaCamioneta;
            this.modelo = modeloCamioneta;
            this.anio = anioCamioneta;
            this.cantidadDePuertas = CantidadDePuertas;

            MostrarinformacionCamioneta();
        }

        public Camioneta(string marcaCamioneta, string modeloCamioneta, int anioCamioneta, int cantidadDePuertasCamioneta, bool es4x4)
        {
            this.marca = marcaCamioneta;
            this.modelo = modeloCamioneta;
            this.anio = anioCamioneta;
            this.cantidadDePuertas = cantidadDePuertasCamioneta;
            this.es4x4 = es4x4;
        }
    }

    class Persona
    {
        string nombre;
        private int? edad;
        int? DNI;

        public Vehiculo vehiculopropio;

        public Persona()
        {
            vehiculopropio = Vehiculo.CrearVehiculoInteractivo();
        }

        public Persona(string nombre, int? edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona(string nombre, int? edad, int? DNI)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
        }

        public void MostrarinformacionPersona(string nombre, int? edad, int? DNI)
        {
            Console.WriteLine($"Persona Creada \n nombre:{nombre} \n edad: {edad} \n DNI: {DNI}");
        }
    }

    class Integrante
    {
        protected int edad;
        protected int antiguedad;
        protected string nombre;
        protected string apellido;

        public Integrante()
        {

        }

        public void Mostrarinformacion()
        {

        }

        public void Renovo()
        {

        }

        public static int Contrato()
        {
            Console.WriteLine("Monto de contrato");
            float monto = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese duracion del contrato");
            int DuraCount = int.Parse(Console.ReadLine());
            return DuraCount;
        }
    }

    class Jugador : Integrante
    {
        string posicion;
        public Jugador()
        {

        }

        public Jugador(string nombre, string apelido, int edad, int antiguedad, string posicion)
        {
            this.nombre = nombre;
            this.apellido = apelido;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.posicion = posicion;
        }

        public void Mostrarinformacion()
        {
            Console.WriteLine($"nombre:\n {nombre}\napellido:\n {apellido}\nedad: \n {edad} \nantiguedad: \n{antiguedad}\nposicion: \n{posicion}");
        }

        public void Renovo()
        {
            Console.WriteLine("Pregntandole al jugador si quiere renovar....");
            Random rnd = new Random();
            string respuesta = rnd.Next(2) == 0 ? "si" : "no";
            Console.WriteLine($"\n \n La respuesta del jugador es..{respuesta}");
        }
    }

    class Tecnico : Integrante
    {
        string especialidad;

        public Tecnico()
        {

        }

        public Tecnico(string nombreTec, string ApellidoTec, int edadTec, int antiguedadTec, string spec)
        {
            this.nombre = nombreTec;
            this.apellido = ApellidoTec;
            this.edad = edadTec;
            this.antiguedad = antiguedadTec;
            this.especialidad = spec;
        }

        public void Mostrarinformacion()
        {
            Console.WriteLine($"nombre:\n {nombre}\napellido:\n {apellido}\nedad: \n {edad} \nantiguedad: \n{antiguedad}\nespecialidad: \n{especialidad}");
        }

        public void Renovo()
        {
            Console.WriteLine("Preguntando al técnico si quiere renovar....");
            Random rnd = new Random();
            int opcion = rnd.Next(3); // 0, 1 o 2
            string respuesta;
            switch (opcion)
            {
                case 0:
                    respuesta = "si";
                    break;
                case 1:
                    respuesta = "no";
                    break;
                case 2:
                    respuesta = "lo tengo que pensar";
                    break;
                default:
                    respuesta = "error";
                    break;
            }
            Console.WriteLine($"\n\n La respuesta del técnico es: {respuesta}");
        }
    }

    class Pokemon
    {
        string nombre;
        int nivel;

        public Pokemon()
        {

        }

        public void Atacar(string eleccion,string pokemonencontrado, Pokemon[] pokemons)
        {
            switch (eleccion.ToLower())
            {
                case "agua":
                    switch(pokemonencontrado.ToLower())
                    {
                        case "agua":
                            Console.WriteLine("Tu pokemon uso Chorro de agua \n No es muy efectivo");
                            int HPVA = pokemons[0].HP();
                            HPVA = HPVA-5;
                            Console.WriteLine($"hiciste 5 de daño, al pokemon le quedan {HPVA}");
                            Console.WriteLine($"El pokemon ha huido, pero lo registraste en la pokedex!!");
                            break;
                        case "fuego":
                            Console.WriteLine("Tu pokemon uso Chorro de agua \n ES MUY EFECTIVO");
                            int HPVF = pokemons[1].HP();
                            HPVF = HPVF-10;
                            Console.WriteLine($"hiciste 10 de daño, al pokemon le quedan {HPVF}");
                            Console.WriteLine($"El pokemon ha sido debilitado, pero lo registraste en la pokedex!!");
                            break;
                        case "electrico":
                            Console.WriteLine("Tu pokemon uso Chorro de agua \n no es muy efectivo");
                            int HPVE = pokemons[2].HP();
                            HPVF = HPVE - 2;
                            Console.WriteLine($"hiciste 2 de daño, al pokemon le quedan {HPVE}");
                            Console.WriteLine($"El pokemon se asustó y huyó, pero lo registraste en la pokedex!!");
                            break;
                    }
                    break;
                case "fuego":
                    switch (pokemonencontrado.ToLower())
                    {
                        case "agua":
                            Console.WriteLine("Tu pokemon uso Llamarada \n No es muy efectivo");
                            int HPVA = pokemons[0].HP();
                            HPVA = HPVA - 2;
                            Console.WriteLine($"hiciste 2 de daño, al pokemon le quedan {HPVA}   hp");
                            Console.WriteLine($"El pokemon se asustó y huyó, pero lo registraste en la pokedex!!");
                            break;
                        case "fuego":
                            Console.WriteLine("Tu pokemon uso Llamarada \n No es muy efectivo");
                            int HPVF = pokemons[1].HP();
                            HPVF = HPVF - 5;
                            Console.WriteLine($"hiciste 5 de daño, al pokemon le quedan {HPVF}  hp");
                            Console.WriteLine($"El pokemon ha huido, pero lo registraste en la pokedex!!");
                            break;
                        case "electrico":
                            Console.WriteLine("Tu pokemon uso Llamarada \n No es muy efectivo");
                            int HPVE = pokemons[2].HP();
                            HPVF = HPVE - 2;
                            Console.WriteLine($"hiciste 2 de daño, al pokemon le quedan {HPVE}  hp");
                            Console.WriteLine($"El pokemon ha huido, pero lo registraste en la pokedex!!");
                            break;
                    }
                    break;
                case "electrico":
                    switch (pokemonencontrado.ToLower())
                    {
                        case "agua":
                            Console.WriteLine("Tu pokemon uso Impactrueno \n Es muy efectivo");
                            int HPVA = pokemons[0].HP();
                            HPVA = HPVA - 10;
                            Console.WriteLine($"hiciste 10 de daño, al pokemon le quedan {HPVA}  hp");
                            Console.WriteLine($"El pokemon se asustó y huyó, pero lo registraste en la pokedex!!");
                            break;
                        case "fuego":
                            Console.WriteLine("Tu pokemon uso Impactrueno \n Es efectivo");
                            int HPVF = pokemons[1].HP();
                            HPVF = HPVF - 8;
                            Console.WriteLine($"hiciste 8 de daño, al pokemon le quedan {HPVF} hp");
                            Console.WriteLine($"El pokemon ha huido, pero lo registraste en la pokedex!!");
                            break;
                        case "electrico":
                            Console.WriteLine("Tu pokemon uso Impactrueno \n no es muy efectivo");
                            int HPVE = pokemons[2].HP();
                            HPVF = HPVE - 2;
                            Console.WriteLine($"hiciste 2 de daño, al pokemon le quedan {HPVE} hp");
                            Console.WriteLine($"El pokemon ha huido, pero lo registraste en la pokedex!!");
                            break;
                    }
                    break;
            }
        }

        public virtual string Rival()
        {
            Console.WriteLine("Entrando en la hierba alta....");
            Random rnd = new Random();
            int opcion = rnd.Next(3); // 0, 1 o 2
            string respuesta;
            switch (opcion)
            {
                case 0:
                    respuesta = "Agua";
                    break;
                case 1:
                    respuesta = "Fuego";
                    break;
                case 2:
                    respuesta = "Electrico";
                    break;
                default:
                    respuesta = "error";
                    break;
            }
            Console.WriteLine($"\n\n el pokemon encontrado es tipo... {respuesta}");
            return respuesta;
        }
        public virtual int HP()
        {
            return 0;
        }

    }

    class PokemonFuego : Pokemon
    {
        int ataque;
        int defensa;
        string objeto;
        
        public PokemonFuego()
        {
            this.ataque = 10;
            this.defensa = 3;
            this.objeto = "nada";
        }

        public override string Rival()
        {
            Console.WriteLine("Entrando en la hierba alta....");
            Random rnd = new Random();
            int opcion = rnd.Next(3); // 0, 1 o 2
            string respuesta;
            switch (opcion)
            {
                case 0:
                    respuesta = "Agua";
                    break;
                case 1:
                    respuesta = "Fuego";
                    break;
                case 2:
                    respuesta = "Electrico";
                    break;
                default:
                    respuesta = "error";
                    break;
            }
            Console.WriteLine($"\n\n el pokemon encontrado es tipo... {respuesta}");
            return respuesta;
        }
        public override int HP()
        {
            return 10;
        }
    }

    class PokemonElectrico : Pokemon
    {
        int ataque;
        int defensa;
        string objeto;

        public PokemonElectrico()
        {
            this.ataque = 8;
            this.defensa = 6;
            this.objeto = "nada";
        }

        public override string Rival()
        {
            Console.WriteLine("Entrando en la hierba alta....");
            Random rnd = new Random();
            int opcion = rnd.Next(3); // 0, 1 o 2
            string respuesta;
            switch (opcion)
            {
                case 0:
                    respuesta = "Agua";
                    break;
                case 1:
                    respuesta = "Fuego";
                    break;
                case 2:
                    respuesta = "Electrico";
                    break;
                default:
                    respuesta = "error";
                    break;
            }
            Console.WriteLine($"\n\n el pokemon encontrado es tipo... {respuesta}");
            return respuesta;
        }
        public override int HP()
        {
            return 13;
        }
    }

    class PokemonAgua : Pokemon
    {
        int ataque;
        int defensa;
        string objeto;

        public PokemonAgua()
        {
            this.ataque = 5;
            this.defensa = 5;
            this.objeto = "nada";
        }

        public override string Rival()
        {
            Console.WriteLine("Entrando en la hierba alta....");
            Random rnd = new Random();
            int opcion = rnd.Next(3); // 0, 1 o 2
            string respuesta;
            switch (opcion)
            {
                case 0:
                    respuesta = "Agua";
                    break;
                case 1:
                    respuesta = "Fuego";
                    break;
                case 2:
                    respuesta = "Electrico";
                    break;
                default:
                    respuesta = "error";
                    break;
            }
            Console.WriteLine($"\n el pokemon encontrado es tipo... {respuesta}");
            return respuesta;
        }

        public override int HP()
        {
            return 15;
        }
    }
}


