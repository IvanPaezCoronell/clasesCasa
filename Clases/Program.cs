using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.IO;

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



            //// DateTime
            //DateTime fechaHora = new DateTime(2010, 01,30);

            //Console.WriteLine(fechaHora);


            //// Convertir una cadena en objetos DateTime
            //string cadenaFecha;
            //DateTime fecha;

            //Console.WriteLine("Digite la fecha y hora:");
            //cadenaFecha = Console.ReadLine();

            //fecha = DateTime.Parse(cadenaFecha);
            //Console.WriteLine(fecha);





            /// Ejercicio - Generador de contraseñas
            //            string usuario, opcion, password;

            //            (bool passwordCheck, string mensajeError) verificarPassword;

            //            Console.WriteLine("Registro");

            //            Console.WriteLine("Digite un nombre de usuario: ");
            //            usuario = Console.ReadLine();


            //            Console.WriteLine("Desea que se le asigne una contrasena automatica? (si/no): ");
            //            opcion = Console.ReadLine();

            //            opcion = opcion.ToLower();

            //            switch (opcion) {
            //                case "si":
            //                    Password paswword1 = new Password();
            //                    password = paswword1.GenerarPassword();

            //                    Console.WriteLine("Constrasena asignada: "+password);

            //                    Console.WriteLine("\n Presiona cualquier tecla para continuar. " );
            //                    Console.ReadKey();
            //                    Console.Clear();
            //                    Console.WriteLine($"\n Tus datos de acceso son los siguientes: \n\tUsuario: {usuario} \n\tcontrasena: {password}");
            //                    break;
            //                case "no":
            //                    Console.WriteLine("\nIngrese una constrasena segura (La constrasena debe contener entre 8-20 caracteres, incluido un numero, una mayuscula, una minuscula y uno caracter especial (#$%&!?): ");
            //                    password = Console.ReadLine();

            //                    Password password2 = new Password();

            //                    verificarPassword = password2.ComprobarPassword(password);

            //                    if(verificarPassword.passwordCheck)
            //                    {
            //                        Console.WriteLine("\nPresione cualquier tecla para continuar.");
            //                        Console.ReadKey();
            //                        Console.Clear();

            //                        Console.WriteLine($"\n Tus datos de acceso son los siguientes: \n\tUsuario: {usuario} \n\tcontrasena: {password}");
            //                    } else
            //                    {
            //                        Console.WriteLine(verificarPassword.mensajeError+" .Ingresa una contrasena valida.");
            //;                    }


            //                    break;

            //            }


            //// ------------------------------- Estructuras y Enumeraciones ------------------------------
            //Cliente cliente1 = new Cliente();
            //cliente1.nombre = "Ivan";
            //cliente1.edad = 23;
            //cliente1.direccion = "calle 40";

            //RegistroClientes registro1 = new RegistroClientes();

            //registro1.RegistrarCliente(cliente1);

            //// Ejercicio con Estructuras
            //bool repetir = true;
            //string opcion;

            //Biblioteca biblioteca = new Biblioteca();

            //do
            //{
            //    Console.WriteLine("\nBiblioteca\n");
            //    Console.WriteLine("1. Agregar libro.");
            //    Console.WriteLine("2. Mostrar todos los libros.");
            //    Console.WriteLine("3. Busqueda exacta de un libro.");
            //    Console.WriteLine("4. Busqueda parcial de un libro.");
            //    Console.WriteLine("5. Eliminar un libro.");
            //    Console.WriteLine("6. salir.");

            //    Console.WriteLine("Ingresa una opcion:  ");
            //    opcion =  Console.ReadLine();

            //    switch (opcion)
            //    {
            //        case "1":
            //            biblioteca.AgregarLibro();
            //            break;
            //        case "2":
            //            biblioteca.MostrarLibro();
            //            break;
            //        case "3":
            //            biblioteca.BuscarLibro();
            //            break;
            //        case "4":
            //            biblioteca.BusquedaParcial();
            //            break;
            //        case "5":
            //            biblioteca.EliminarLibro();
            //            break;
            //        case "6":
            //            repetir = false;

            //            break;
            //        default:
            //            Console.WriteLine("Opcion invalida");
            //            break;

            //    }

            //} while (repetir = true);


            // Declaracion de una variable de tipo enum
            //Semana diaPago = Semana.Viernes ;


            // Clase  Type y TypeOf

            //Type numeroEntero;
            //numeroEntero = typeof(int);
            //Console.WriteLine(numeroEntero.IsValueType);


            //Type datoStruct = typeof(Libro);
            //Type datoClass = typeof(Biblioteca);
            ////Console.WriteLine(datoStruct.Name);
            ////Console.WriteLine(datoClass.Name);

            //// Declaracion de una matriz tipo FieldInfo
            //FieldInfo[] camposDatoStruct;

            //camposDatoStruct = datoStruct.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //foreach (FieldInfo item in camposDatoStruct)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("Campo del tipo: ");

            //// ------------------------------- Flujos y Archivos ------------------------------
            //MemoryStream stream = new MemoryStream();   

            //Console.WriteLine("Ingrese un texto para guardarlo: ");
            //string cadena1 = Console.ReadLine();


            //byte[] matrizCadenaByte;


            //// Codificamos a cadena1 para ohtener una secuencioa de bytes
            //matrizCadenaByte = Encoding.UTF8.GetBytes(cadena1);


            //// ------------------------------- Excepeciones ------------------------------
            //int a = 0;
            //int b = 10;
            //int resultado = 0;

            //try
            //{
            //    resultado = b / a;
            //} catch (Exception error) {
            
            //    Console.WriteLine("No es posible dividir entre un valor de cero.");                                                            
            //} finally
            //{
            //    Console.WriteLine(resultado);
            //}





        }






        // Declracion de una enum
        enum Semana
        {
            Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
        }

        ////Estructuras y Enumeraciones
        class Jugador
        {
            string nombre;
           int vida;
            int puntaje;
           List<Item> inventario;
        }

        struct Item
        {
            string nombre;
            int tipo;
            int dano;
            int vida;

        }

        struct Cliente
        {
            public string nombre;
            public int edad;
            public string direccion;
        }

        class RegistroClientes
        {
            List<Cliente> listaClientes = new List<Cliente>();


            public void RegistrarCliente(Cliente clientPa)
            {
                listaClientes.Add(clientPa);
            }
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

    // Ejercicio con Estructuras

    class Biblioteca
    {
        Libro[] libros;
        int cantidadLibros = 0;
        string buscarLibro;
        bool libroEncontrado;
        int posicionLibroEliminar;


        // Constructor
        public Biblioteca()
        {
            libros = new Libro[1000];
        }


        public void AgregarLibro()
        {
            // Se verifica si se puede ingresar un libro
            if(cantidadLibros < libros.Length)
            {
                Console.Clear();
                Console.WriteLine($"Ingresar informacion para el libro {cantidadLibros + 1}");


                Console.WriteLine("Ingresa el nombre del libro: ");
                libros[cantidadLibros].Titulo = Console.ReadLine();

                Console.WriteLine("Ingresa el autor: ");
                libros[cantidadLibros].Autor = Console.ReadLine();

                Console.WriteLine("Ingresa el anio: ");
                libros[cantidadLibros].Anio = Console.ReadLine();

                cantidadLibros++;

                Console.Clear();
                Console.WriteLine($"Libro agregado correctamente!");

            } else
            {
                Console.WriteLine("Biblioteca llena, intenta eliminar un libro.");
            }
        }

        public void MostrarLibro()
        {
            Console.Clear();

            if (cantidadLibros == 0)
            {
                Console.WriteLine("Biblioteca vacia, Agrega libros para poder visualizar.");
            } else
            {
                for (int i = 0; i < cantidadLibros; i++)
                {
                    Console.WriteLine($"{i + 1}. - Titulo = {libros[i].Titulo}, Autor = {libros[i].Autor}, Anio = {libros[i].Anio}");
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        public void BuscarLibro()
        {
            Console.Clear();

            Console.WriteLine("Ingresar el nombre exacto del libro para buscarlo: ");
            libroEncontrado = false;

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.Equals(buscarLibro))
                {
                    Console.WriteLine($"El libro \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" se encuentra disponible en la biblioteca en el indice: {i+1}" );
                    libroEncontrado = true;
                } 
            }
            if( !libroEncontrado )
            {
                Console.WriteLine("Libro no encontrado.\n");
            }
        }

        public void BusquedaParcial()
        {
            Console.Clear();

            Console.WriteLine("Ingrese al menos una parte del titulo o del nombre del autor de un libro: ");
            buscarLibro = Console.ReadLine().ToLower();

            libroEncontrado = false;

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.ToLower().Contains(buscarLibro) || libros[i].Autor.ToLower().Contains(buscarLibro))
                {
                    Console.WriteLine($"La palabra \"{buscarLibro}\" fue encontrada en el libro: \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" en el indice: {i +i}" );
                }
                
            }

            if (!libroEncontrado)
            {
                Console.WriteLine("No se encontraron coincidencias.");
            }

        }

        public void EliminarLibro()
        {
            Console.Clear();

            if(cantidadLibros == 0)
            {
                Console.WriteLine("La biblioteca esta vacia, no hay nada que eliminar");
            } else {
                Console.Write($"Ingresa el numero de libro que desea eliminar (Del 1 al {cantidadLibros}): ");
                posicionLibroEliminar = Convert.ToInt32( Console.ReadLine()) -1;

                if(posicionLibroEliminar >= 0 && posicionLibroEliminar < cantidadLibros)
                {
                    Console.WriteLine($"El libro que deseas eliminar es: \"{libros[posicionLibroEliminar].Titulo}\"? (si/no): ");
                    string opcion = Console.ReadLine().ToLower();

                    if(opcion == "si")
                    {
                        string tituloEliminado = libros[posicionLibroEliminar].Titulo;
                        string autorEliminado = libros[posicionLibroEliminar].Autor;

                        for (int i = posicionLibroEliminar; i < cantidadLibros; i++)
                        {
                            libros[i] = libros[i + 1];
                        }

                        cantidadLibros--;

                        Console.WriteLine($"\n El libro \"{tituloEliminado}\" del autor(a): \"{autorEliminado}\" fue eliminado! ");

                    } else
                    {
                        Console.WriteLine("Operacion \"eliminar libro\" cancelada.");
                    }
                }
                else
                {
                    Console.WriteLine("EL numero de libro noes valido!");
                }
            }

        }

    }


    struct Libro {
         string titulo;
         string autor;
         string anio;


        // Propiedades
        public string Titulo
        {
            get => titulo; set => titulo = value;
        }

        public string Autor
        {
            get => autor; set => autor = value;
        }

        public string Anio
        {
            get => anio; set => anio = value;
        }
    
    }



    // Ejercio generar passwword
    class Password
    {
        string numeros = "0123456789";
        string letrasMin = "abcdefghijklmnñopqrstuvwxyz";
        string letrasMayus = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        string caracterEspecial = "$%#&!?";

        int mumContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;

        public string GenerarPassword()
        {
            string password = "";

            Random rdm = new Random();

            // Longitud para la contrasena
            int longitud = rdm.Next(8, 21);


            // Variables que determinan cuantos caracteres se van a usar del grupo
            double numTener = longitud * .15; // Porcentajes que debe tener
            double minTener = longitud * .35;
            double mayTener = longitud * .35;
            double espTener = longitud * .15;


            int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;

            // Variable que va almacenar cada caracter de la constrasena
            char caracter;

            // Colocar un caracter hasta que se complete la longitud
            while (password.Length < longitud)
            {
                switch (rdm.Next(0, 4))
                {
                    case 0:
                        if (numContiene < numTener)
                        {
                            // A caracter se le asigna un caracter aleatorio de los contenidos en el string numeros, basandose en el indice y apoyandose de la propiedad "Length"
                            caracter = numeros[rdm.Next(numeros.Length)];

                            password += caracter;

                            numContiene++;

                        }
                        break;
                    case 1:
                        if(minContiene < minTener)
                        {
                            caracter = letrasMin[rdm.Next(letrasMin.Length)];
                            password += caracter;

                            minContiene++;

                        }

                        break;
                    case 2:
                        if (mayContiene < mayTener)
                        {
                            caracter = letrasMayus[rdm.Next(letrasMayus.Length)];
                            password += caracter;

                            mayContiene++;

                        }
                        break;
                    case 3:
                        if (espContiene < espTener)
                        {
                            caracter = caracterEspecial[rdm.Next(caracterEspecial.Length)];
                            password += caracter;

                            espContiene++;

                        }
                        break;
                }

            }
            return password;
        }

        public (bool, string) ComprobarPassword(string passwordPa)
        {
            bool passwordCheck = false, hayNumero = false, hayMinuscula = false, hayMayuscula = false, hayEspecial = false;

            string mensajeError = "";

            if (passwordPa.Length >= 8 && passwordPa.Length <= 20) {
               foreach(char elemento in numeros)
                {
                    if(passwordPa.IndexOf(elemento) >= 0)
                    {
                        hayNumero = true;
                        break;
                    } else
                    {
                        hayNumero = false;
                        mensajeError = "La contrasena debe contener al menos un numero!";
                    }
                }

               if(hayNumero)
                {
                    foreach(char elemento in letrasMin)
                    {
                        if(passwordPa.IndexOf(elemento) >= 0)
                        {
                            hayMinuscula = true;
                            break;

                        } else
                        {
                            hayMinuscula = false;
                            Console.WriteLine("La constrasebna debe tener al menos una letra en minuscula.");
                        }
                    } 
                }

                if (hayMinuscula)
                {
                    foreach(char elemento in letrasMayus)
                    {
                        if (passwordPa.IndexOf(elemento) >= 0)
                        {
                            hayMayuscula = true;
                            break;
                        } else
                        {
                            hayMayuscula = false;
                                Console.WriteLine("La constrasena debe tener al menos una letra en mayuscula.");
                        }
                    }
                }

                if (hayMayuscula)
                {
                    foreach (char elemento in caracterEspecial)
                    {
                        if(passwordPa.IndexOf(elemento) >= 0)
                        {
                            hayEspecial = true;
                            break;
                        } else
                        {
                            hayEspecial = false;
                            Console.WriteLine("La contrasena debe tener al menos un caracter especial.");
                        }

                    }
                }

                if (hayNumero && hayMinuscula && hayMayuscula && hayEspecial)
                {
                    passwordCheck = true;
                } else
                {
                    passwordCheck = false;
                }
                



            } else
            {
                mensajeError = "La contrasena debe contener entre 8-20 caracteres!";
                passwordCheck = false;
            }

            return (passwordCheck, mensajeError);
                
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

    //public class Nombre
    //{
    //    public string Concatenar(string nombre, string apellido)
    //    {
    //        string nombreApellido;
    //        nombreApellido = nombre + " " + apellido;
    //        return nombreApellido;
    //    }


    //    // Sobrecarga 
    //    public string Concatenar(string nombre, string apellido, string apellido2)
    //    {
    //        string nombreApellido;
    //        nombreApellido = nombre + " " + apellido + " " + apellido2;
    //        return nombreApellido;
    //    }

    //}


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
