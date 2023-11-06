using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ------------------------------- POO ------------------------
            //bool acelerar;

            //Auto auto1 = new Auto();
            //auto1.Color = "blanco";
            //auto1.Modelo = "Kia Rio";
            //auto1.Combustible = "Diesel";
            //auto1.Año = "2023";
            //auto1.NPuertas = "4";

            //Console.WriteLine(auto1.ToString());



            //string nombreYAppellido;
            //Nombre nombre = new Nombre();

            //nombreYAppellido = nombre.Concatenar("Ivan", "Paez", "Coronell");
            //Console.WriteLine(nombreYAppellido);



            //// Clase Random
            //Random random = new Random();
            //Console.WriteLine(random.Next(1,10));




            // Empleado
            //string nombre, apellido, nip;


            //Console.WriteLine("Nombre: ");
            //nombre = Console.ReadLine();

            //Console.WriteLine("Appelido: ");
            //apellido = Console.ReadLine();

            //Console.WriteLine("Nip: ");
            //nip = Console.ReadLine();

            //Empleado empleado1 = new Empleado(nombre, apellido);


            //empleado1.Nip = nip;


            //Console.WriteLine( empleado1.ToString());




            // ------------------------------- Colecciones Genericas ------------------------

            // Convercion explicita - Expresion CAST
            //int numGrande = 500;
            //byte numPequeño = (byte)numGrande;
            //Console.WriteLine(numGrande);
            //Console.WriteLine(numPequeño);

            //// Boxing
            //int a = 50;
            //object obj = a;

            //// Umboxing
            //object numero1 = 10;
            //object resultado;
            //resultado = (int)numero1 + 5;


            //// Ejemplo sin Genericos
            //string valorElemento;
            //GuardarObjetos objetos1 = new GuardarObjetos(3);
            //objetos1.AgregarElemento("Ivan");
            //objetos1.AgregarElemento("David");
            //objetos1.AgregarElemento("Ana");
            //valorElemento = (string)objetos1.ObtenerElemento(2);
            //Console.WriteLine(valorElemento);


            //// Genericos
            //string valorElemento2;
            //EjemploGenerico<String> objeto2 = new EjemploGenerico<string>(2);
            //objeto2.AgregarElemento("David");
            //objeto2.AgregarElemento("Ana");
            //valorElemento2 = (string)objeto2.ObtenerElemento(0);
            //Console.WriteLine(valorElemento2);

            // List
            //string elem;
            //int opcion;

            //List<string> lista = new List<string>();

            //do
            //{
            //    Console.WriteLine("1. agregar elemento.");
            //    Console.WriteLine("2. salir.");
            //    opcion = Convert.ToInt32(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        Console.WriteLine("ingrese el elemento: ");
            //        elem = Console.ReadLine();
            //        lista.Add(elem);
            //    }

            //} while (opcion == 1);


            //// ForEach para recorrer colecciones
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}


            /// Ejercicio con lista
            //int opcion, indice;
            //string alumno;

            //List<string> listaAlumnos = new List<string>();

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("1. Agregar estudiante.");
            //    Console.WriteLine("2. Eliminar estudiante.");
            //    Console.WriteLine("3. Mostrar estudiante.");
            //    Console.WriteLine("4. Buscar estudiante.");



            //    Console.WriteLine("Escoge una opcion: ");
            //    opcion =Convert.ToInt32( Console.ReadLine());

            //    Console.Clear();

            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("Digite un nombre para agregar a la lista: ");
            //            alumno = Console.ReadLine();
            //            listaAlumnos.Add(alumno);
            //            break;
            //        case 2:
            //            Console.WriteLine("Ingrese el alumno que desea eliminar: ");
            //            indice = Convert.ToInt32(Console.ReadLine());
            //            indice--;

            //            if (indice >= listaAlumnos.Count() || indice < 0)
            //            {
            //                Console.WriteLine("El alumno no existe");
            //            }
            //            else
            //            {
            //                string alumnoElim = listaAlumnos[indice];
            //                listaAlumnos.RemoveAt(indice);

            //                Console.WriteLine("{0} Se ha elimindao correctamente!", alumnoElim);
            //            }


            //            Console.WriteLine("Presione cualquier tecla para regresar al menu");
            //            Console.ReadKey();

            //            break;
            //        case 3:
            //            int i = 1;
            //            Console.WriteLine("Lista de Alumnos");

            //            foreach (var item in listaAlumnos)
            //            {
            //                Console.WriteLine("{0}. {1}", i++, item);

            //            }
            //            Console.WriteLine("Presione cualquier tecla para regresar al menu");
            //            Console.ReadKey();
            //            break;
            //        case 4:
            //            string encontrarAlumno;
            //            int j; // numero de lista

            //            Console.WriteLine("Digitar el alumno a buscar: ");
            //            alumno = Console.ReadLine();

            //            // verificar si el alumno esta o no en las lista
            //            if(listaAlumnos.IndexOf(alumno) >= 0)
            //            {
            //                encontrarAlumno = listaAlumnos[listaAlumnos.IndexOf(alumno)];
            //                j = listaAlumnos.IndexOf(alumno) +1;

            //                Console.WriteLine("El alumno {0} se encuentra en el numero {1} de la lista.", encontrarAlumno, j);

            //            } else
            //            {
            //                Console.WriteLine("El alumno no se encuentra en el sistema.");
            //            }


            //            Console.WriteLine("Presione cualquier tecla para regresar al menu");
            //            Console.ReadKey();
            //            break;

            //    }




            //} while (opcion >= 1 && opcion <= 4);


            //// Stack o pila
            //Stack <double> miPila = new Stack <double> ();
            //miPila.Push(5);
            //miPila.Push(10);
            //miPila.Push(15);
            //var elementoEliminado= miPila.Pop();
            //bool encontrar;
            //double buscarElemento;


            //int j = 0;

            //foreach (int i in miPila)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Digite el elemento qu quiere encontrar: ");
            //buscarElemento = Convert.ToDouble(Console.ReadLine());

            //encontrar = miPila.Contains(buscarElemento);

            //if (encontrar)
            //{
            //    Console.WriteLine("El objbeto {0} se encontro en la pila.", buscarElemento);
            //}
            //else
            //{
            //    Console.WriteLine("El objbeto {0} NO se encontro en la pila.", buscarElemento);
            //}


            //// Queue
            //Queue<char> miCola = new Queue<char>();
            //miCola.Enqueue('a');
            //miCola.Enqueue('b');
            //miCola.Enqueue('c');
            //miCola.Enqueue('d');
            //miCola.Dequeue();

            //int i=0;

            //foreach (var item in miCola)
            //{
            //    Console.WriteLine("{0}. {1}",i++,item);
            //}


            //// Dictionary
            //Dictionary<string, int> empleadosDiccionario = new Dictionary<string,int>();

            //empleadosDiccionario.Add("Ivan", 23);
            //empleadosDiccionario.Add("Ana", 22);
            //empleadosDiccionario.Add("Paco", 22);

            //// Propiedad Item[]
            //empleadosDiccionario["David"] = 26;

            //empleadosDiccionario.Remove("Paco");



            //foreach (KeyValuePair <string, int> item in empleadosDiccionario)
            //{
            //    Console.WriteLine(item);
            //}

            //// Usando el get de la propiedad Item[]
            //Console.WriteLine("La edad de Ivan es: {0} ", empleadosDiccionario["Ivan"]);


            //// Ejemplo con Diccionario
            //Dictionary<string, long> contactos = new Dictionary<string, long>();

            //int opcion;
            //string nombre;
            //long numero;


            //do
            //{
            //    Console.WriteLine("1. Agregar contacto. ");
            //    Console.WriteLine("2. Buscar contacto. ");
            //    Console.WriteLine("3. Eliminar contacto. ");
            //    Console.WriteLine("4. Mostrar contacto. ");
            //    Console.WriteLine("4. Actualizar contacto. ");

            //    Console.WriteLine("\nEliga una opcion: ");
            //    opcion = Convert.ToInt32(Console.ReadLine());

            //    Console.Clear();


            //    switch (opcion)
            //    {
            //        case 1: 
            //            Console.WriteLine("Nombre: "); 
            //            nombre = Console.ReadLine();
            //            Console.WriteLine("Numero: ");
            //            numero = Convert.ToInt64(Console.ReadLine());

            //            contactos.Add(nombre, numero);
            //            Console.WriteLine("\nEl contacto ha sido registrado correctamente! ");

            //            Console.WriteLine("\nPresiona cualquier tecla para regresr al menu. ");
            //            Console.ReadKey();

            //            break;
            //        case 2: 
            //            Console.WriteLine("Escribir el nombre: ");
            //            nombre = Console.ReadLine();

            //            if (contactos.ContainsKey(nombre))
            //            {
            //                Console.WriteLine("Contacto encontrado.");
            //                Console.WriteLine("{0} - {1}", nombre, contactos[nombre]);

            //                Console.WriteLine("\nPresiona cualquier tecla para regresr al menu. ");
            //                Console.ReadKey();

            //            } else
            //            {
            //                Console.WriteLine("Contacto NO encontrado!");

            //            }

            //            break;
            //        case 3: 
            //            Console.WriteLine("Digite el nombre: "); 
            //            nombre = Console.ReadLine();

            //            if (contactos.ContainsKey(nombre))
            //            {
            //                contactos.Remove(nombre);
            //                Console.WriteLine("El contacto se ha eliminado correctamente!");

            //                Console.WriteLine("\nPresiona cualquier tecla para regresr al menu. ");
            //                Console.ReadKey();

            //            } else
            //            {
            //                Console.WriteLine("Contacto NO encontrado!");
            //                Console.WriteLine("\nPresiona cualquier tecla para regresr al menu. ");
            //                Console.ReadKey();
            //            }
            //            break;
            //        case 4: 
            //            Console.WriteLine();
            //            Console.WriteLine("Contactos");

            //            foreach (KeyValuePair<string, long> item in contactos)
            //            {
            //                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            //            }

            //            Console.WriteLine("\nPresiona cualquier tecla para regresr al menu. ");
            //            Console.ReadKey();

            //            break;
            //        case 5: 
            //            Console.WriteLine("Digite el nombre: ");
            //            nombre = Console.ReadLine();

            //            if (contactos.ContainsKey(nombre))
            //            {
            //                Console.Write("\nEscribir el nuevo numero: ");
            //                numero = Convert.ToInt64(Console.ReadLine());

            //                contactos[nombre] = numero;

            //                Console.Write("\nInformacion actualizada! ");

            //                Console.WriteLine("{0} - {1}", nombre, contactos[nombre]);

            //                Console.WriteLine("\nPresiona cualquier tecla para regresr al menu. ");
            //                Console.ReadKey();


            //            } else
            //            {
            //                Console.WriteLine("Contacto NO encontrado!");
            //                Console.WriteLine("\nPresiona cualquier tecla para regresr al menu. ");
            //                Console.ReadKey();
            //            }

            //            break;
            //    }

            //} while (opcion >= 1 && opcion <= 5);




            // ------------------------------- Cadenas ------------------------------

            //string text = "hola, a todos";
            //string[] palabras = text.Split(' ', ',');

            //foreach (string item in palabras)
            //{
            //    Console.WriteLine(item);
            //}

            // Buscar palabra
            //string parrafo = "---hola soy un parrafo con palabras y numeros 1 2 3. ---";

            //string palabraRemplazo = parrafo.Replace("palabras", "palabra");
            //Console.WriteLine(palabraRemplazo);


            //string palabraRemplazo2 = parrafo.Trim('-');
            //Console.WriteLine(palabraRemplazo2);

            //string palabraRemplazo3 = parrafo.Remove(45, 5);
            //Console.WriteLine(palabraRemplazo3);

            //Console.WriteLine("ingrese el texto a buscar: ");
            //string buscartexto = Console.ReadLine();

            //if (parrafo.Contains(buscartexto))
            //{
            //    Console.WriteLine("palabra {0} encontrada.", buscartexto);
            //}
            //else
            //{
            //    Console.WriteLine("no se encontro la palabra {0} en el parrafo.", buscartexto);
            //}


            // Clase StringBuilder

            //StringBuilder numeros = new StringBuilder();


            //for (int i = 1; i < 100; i++)
            //{
            //    numeros.Append(i);
            //    numeros.Append(", ");
            //}

            //Console.WriteLine(numeros);


            // Comparacion ordinal de cadenas
            //string cadena1 = "Hola mundo";
            //string cadena2 = "hola mundo";

            //bool igual;
            //igual = cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase);

            //Console.WriteLine(igual);



            // DateTime
            DateTime fechaHora = new DateTime(2010, 01,30);

            Console.WriteLine(fechaHora);


            // Convertir una cadena en objetos DateTime
            string cadenaFecha;
            DateTime fecha;

            Console.WriteLine("Digite la fecha y hora:");
            cadenaFecha = Console.ReadLine();

            fecha = DateTime.Parse(cadenaFecha);
            Console.WriteLine(fecha);















        }



        // Ejemplo sin generico
        class GuardarObjetos {
            private int i = 0;
            private object[] matrizElementos;

            // Constructor
            public GuardarObjetos(int elementosPa)
            {
                matrizElementos = new object[elementosPa];
            }

            // Metodos
            public void AgregarElemento(object elementoPa)
            {
                matrizElementos[i] = elementoPa;
                i++;

            }

            public object ObtenerElemento(int elementoPa)
            {
                return matrizElementos[elementoPa];

            }


        }


        // Ejemplo generico
        class EjemploGenerico<T>
        {

            private int i = 0;
            private T[] matrizElementos;

            // Constructor
            public EjemploGenerico(int elementosPa)
            {
                matrizElementos = new T[elementosPa];
            }

            // Metodos
            public void AgregarElemento(T elementoPa)
            {
                matrizElementos[i] = elementoPa;
                i++;

            }

            public T ObtenerElemento(int elementoPa)
            {
                return matrizElementos[elementoPa];

            }

        }

    }



    public class  Auto
    {
        private string color = "rojo", modelo, combustible, año, nPuertas;
        private int motor;

        private string asientos, colorTablero;
        private bool camaraTrasera;


        // Constructor
        public Auto()
        {
            asientos = "blancos";
            colorTablero = "cafe";
            camaraTrasera = false;
        }
       

    
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Modelo
        {
            get { return modelo;} 
            set { modelo = value;}
        }

        public string Combustible
        {
            get { return combustible; }
            set { combustible = value;}
        }

        public int Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        public string Año
        {
            get { return año; }
            set{ año = value; }
        }

        public string NPuertas
        {
            get { return nPuertas; }
            set { nPuertas = value;}
        }



        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("El auto esta acelerando");
            return acelerar;
        }

        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("El auto esta frenando");
            return frenar;
        }

        public void Velocidades(ref byte velocidad)
        {
            velocidad++;
            Console.WriteLine("Cambio de velocidad.");
            
        }


        // Invalidando metodo ToString 
        public override string ToString()
        {
            string mensaje;
            mensaje = "Modelo: " + modelo + " Color: " + color + " Año: " + año + " Puertas: " + nPuertas + " Asientos: " + asientos + " Color del tablero: "+colorTablero+ " Camara trasera: "+ camaraTrasera;
            return mensaje;
        }

        
    }

    public class Nombre
    {
        public string Concatenar(string nombre, string apellido)
        {
            string nombreApellido;
            nombreApellido = nombre + " " + apellido;
            return nombreApellido;
        }


        // Sobrecarga 
        public string Concatenar(string nombre, string apellido, string apellido2)
        {
            string nombreApellido;
            nombreApellido = nombre + " " + apellido + " " + apellido2;
            return nombreApellido;
        }

    }


    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string id;
        private string locker;
        private string banco;
        private string nip;


        public Empleado(string nombreC, string apellidoC)
        {
            nombre = nombreC;
            apellido = apellidoC;
            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignarBanco();
        }

        Random rdm = new Random();


        public string Nip
        {
            set { nip = value; }
        }


        private string GenerarID()
        {
      
            int numero;
            string id = "";


            for (int i = 0; i < 10; i++)
            {
                numero = rdm.Next(10);
                id += numero.ToString();
            }
            return id;
        }


        private string GenerarLocker()
        {

            int numero;
            string locker = "";


            for (int i = 0; i < 2; i++)
            {
                numero = rdm.Next(10);
                locker += numero.ToString();
            }
            return locker;
        }


        private string AsignarBanco()
        {

            int asignarBanco;
            string banco = "";

            asignarBanco = rdm.Next(1, 3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;
                case 2:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }


        public override string ToString()
        {
           string mensaje = "";

           mensaje = "Empleado: " + nombre + "\nApellido: " + apellido + "\nID: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco;
            return mensaje;
        }




    }

}
