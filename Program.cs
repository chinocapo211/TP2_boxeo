int numMenu = 0;
boxeador peleador1 =  new boxeador();
boxeador peleador2 =  new boxeador();
do{
    numMenu = pedirInt(1,4,"Ingrese la opcion del menu \n1)Cargar Boxeador 1 \n2)Cargar Boxeador 2 \n3)Pelea \n4)Salir");
    switch(numMenu)
    {
        case 1:
            peleador1 = crearPeleador();
        break;
        case 2:
            peleador2 = crearPeleador();
        break;
        case 3:
            if(peleador1.nombre != null || peleador2.nombre != null)
            {
                double puntaje = peleador1.obtenerSkills() -  peleador2.obtenerSkills();
                string nombreGanador = "";

                if (puntaje > 0) nombreGanador=peleador1.nombre;
                else if (puntaje < 0) 
                {
                    nombreGanador = peleador2.nombre;
                    puntaje *= -1;
                }

                if (puntaje == 0) Console.WriteLine("Empate");
                else if (puntaje > 30) Console.WriteLine($"Ganó {nombreGanador} por KO");
                else if (puntaje > 10 && puntaje <= 30) Console.WriteLine($"Ganó {nombreGanador} por puntos en fallo unánime");
                else if (puntaje > 0 && puntaje <= 10) Console.WriteLine($"Ganó {nombreGanador} por puntos en fallo dividido");

            }
            else
            {
                Console.WriteLine("Alguno de los dos boxeadores no esta cargado!");
            }
        break;
    }
}while(numMenu != 4);

boxeador crearPeleador()
{
    string nombre,pais;
    int peso,potenciaGolpes,velocidadPiernas;
    nombre = pedirCadena("Ingrese el nombre del peleador");
    pais = pedirCadena("Ingrese el pais del peleador");
    peso = pedirInt(1,150,"Ingrese el peso del peleador");
    potenciaGolpes = pedirInt(1,100,"Ingrese la potencia de los golpes del peleador");
    velocidadPiernas = pedirInt(1,100,"Ingrese la velocidad de piernas del peleador");
    boxeador devolver = new boxeador(nombre,pais,peso,potenciaGolpes,velocidadPiernas);
    return devolver;
}
string pedirCadena(string msj)
{
    string devolver;
    Console.WriteLine(msj);
    devolver = Console.ReadLine();
    return devolver;
}
int pedirInt(int minimo, int maximo, string msj)
{
    int devolver;
    Console.WriteLine(msj);
    devolver = int.Parse(Console.ReadLine());
    while(devolver < minimo || devolver > maximo)
    {
        Console.WriteLine($"El numero debe estar dentro del limite, vuelva a intentar");
        devolver = int.Parse(Console.ReadLine());
    }
    return devolver;
}