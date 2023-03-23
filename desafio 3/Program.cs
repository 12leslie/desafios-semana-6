
utilizando appListaPerson . controladores;
utilizando appListaPerson . modelos;
utilizando el sistema ;

espacio de nombres  listPersonApp
{
     programa de clase
    {
        public static void Main(cadena[] args)
{

    PersonController obj = nuevo();
    int opcion = 0;

    hacer
            {
        consola _ WriteLine(" * menú principal * " +
            " \n 1. Agregar persona " +
            " \n 2. Mostrar la lista " +
            " \n 3. Eliminar la lista " +
            " \n 4. Actualizar la lista " +
            " \n 5. Salir " +
            " \n elige tu opcion :) ");

        var datos = Consola.Línea de lectura();
        si(datos! = nulo)
                {
            opción = int.Analizar(datos);
        }

        cambiar(opción)
                {
            caso  1 :
                        consola _ WriteLine ( " Escriba el id: " );
var inputId = Consola.Línea de lectura ();
consola _ WriteLine ( " Escriba el nombre: " );
var inputName = Consola.Línea de lectura ();
consola _ WriteLine ( " Escriba la edad: " );
var inputAge = Consola.Línea de lectura ();

if (identificador de entrada  ! = nulo && nombre de entrada  ! =  nulo  &&  edad de entrada  ! =  nulo )
                        {
    objeto _ AddPerson(nueva  Persona(
        int.Analizar(entradaId),
        nombreEntrada.a la cadena(),
        int.Analizar(edad de entrada)
        ));
}

romper;

caso  2 :
                        consola _ WriteLine ( obj . ShowList ());
romper;

caso  3 :
                        consola _ WriteLine ( " Escriba el id de la persona a eliminar " );
var IdDelete = Consola.Línea de lectura ();
objeto _ DeletePerson ( int . Parse ( IdDelete ));
romper;
caso  4 :

                        consola _ WriteLine ( " Escriba el id de la persona " );
var IdSearch = Consola.Línea de lectura ();

consola _ WriteLine ( " Escriba el id: " );
var Id = Consola.Línea de lectura ();
consola _ WriteLine ( " Escriba el nombre: " );
var Nombre = Consola.Línea de lectura ();
consola _ WriteLine ( " Escriba la edad: " );
var Edad = Consola.Línea de lectura ();

if (Id != nulo && Nombre != nulo && Edad != nulo)
{
    objeto _ UpdatePerson(int.Parse(IdSearch), nueva  Persona(
        int.Analizar(Id),
        nombre,
        int.Analizar(Edad)
        ));
}
romper;
caso  5 :
                        opción = 5;
romper;
predeterminado:
consola _ WriteLine(" elige una opcion del menu ");
romper;
                }

            } while (opción != 5) ;
        }

    }
}