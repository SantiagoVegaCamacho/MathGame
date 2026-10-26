namespace MathGame;


public class Juego
{
   
    string[] rankNombres = new string[50];
    int[] rankPuntos = new int[50];
    int rankCantidad = 0;

    
    public string[] Nombres = new string[2];
    public int[] Puntos = new int[2];
    public int[] Vidas = new int[2];
    public int Jugadores;
    public int Turno;
    public int Nivel;
    public bool SubioNivel;
    public string Pregunta;

    int aciertosTotales;
    int resultado;
    Random azar = new Random();

    
    public void Iniciar(string nombre1, string nombre2, int jugadores)
    {
        Nombres[0] = nombre1;
        Nombres[1] = nombre2;
        Jugadores = jugadores;
        for (int i = 0; i < 2; i++)
        {
            Puntos[i] = 0;
            Vidas[i] = 3;
        }
        Turno = 0;
        Nivel = 1;
        aciertosTotales = 0;
        NuevaOperacion();
    }

    
    void NuevaOperacion()
    {
        int max = Nivel * 10;                 
        if (max > 100) max = 100;

        int cantidadOperaciones = Nivel + 1;  
        if (cantidadOperaciones > 4) cantidadOperaciones = 4;

        int op = azar.Next(1, cantidadOperaciones + 1);
        int a = azar.Next(1, max + 1);
        int b = azar.Next(1, max + 1);
        char operador = '+';

        switch (op)
        {
            case 1:
                operador = '+';
                resultado = a + b;
                break;
            case 2:
                operador = '-';
                if (b > a) { int temp = a; a = b; b = temp; }
                resultado = a - b;
                break;
            case 3:
                operador = '*';
                a = azar.Next(2, 13);
                b = azar.Next(2, 13);
                resultado = a * b;
                break;
            case 4:
                operador = '/';
                b = azar.Next(2, 11);
                resultado = azar.Next(1, 11);
                a = b * resultado;           
                break;
        }
        Pregunta = a + " " + operador + " " + b + " = ?";
    }

    
    public int Responder(string texto)
    {
        int respuesta;
        if (!int.TryParse(texto.Trim(), out respuesta))
            return 0;                         

        SubioNivel = false;
        int resp;
        if (respuesta == resultado)
        {
            resp = 1;
            Puntos[Turno] += 10 * Nivel;
            aciertosTotales++;
            int nivelNuevo = 1 + aciertosTotales / 3;  
            if (nivelNuevo > Nivel) SubioNivel = true;
            Nivel = nivelNuevo;
        }
        else
        {
            resp = 2;
            Vidas[Turno]--;
        }

        CambiarTurno();
        if (!Terminada()) NuevaOperacion();
        return resp;
    }

    void CambiarTurno()
    {
        if (Jugadores == 2)
        {
            int otro = 1 - Turno;             
            if (Vidas[otro] > 0) Turno = otro;
        }
    }

    
    public bool Terminada()
    {
        for (int i = 0; i < Jugadores; i++)
        {
            if (Vidas[i] > 0) return false;
        }
        return true;
    }

    
    public int Ganador()
    {
        if (Puntos[0] == Puntos[1]) return -1;
        if (Puntos[0] > Puntos[1]) return 0;
        return 1;
    }

    
    public void GuardarEnRanking()
    {
        for (int i = 0; i < Jugadores; i++)
        {
            if (rankCantidad < 50)
            {
                rankNombres[rankCantidad] = Nombres[i];
                rankPuntos[rankCantidad] = Puntos[i];
                rankCantidad++;
            }
        }
        OrdenarRanking();
    }

    
    void OrdenarRanking()
    {
        for (int i = 0; i < rankCantidad - 1; i++)
        {
            for (int j = 0; j < rankCantidad - 1 - i; j++)
            {
                if (rankPuntos[j] < rankPuntos[j + 1])
                {
                    int p = rankPuntos[j];
                    rankPuntos[j] = rankPuntos[j + 1];
                    rankPuntos[j + 1] = p;

                    string n = rankNombres[j];
                    rankNombres[j] = rankNombres[j + 1];
                    rankNombres[j + 1] = n;
                }
            }
        }
    }

    
    public int MejorPuntaje(string nombre)
    {
        int mejor = -1;
        for (int i = 0; i < rankCantidad; i++)
        {
            if (rankNombres[i].ToLower() == nombre.ToLower() && rankPuntos[i] > mejor)
                mejor = rankPuntos[i];
        }
        return mejor;
    }

    
    public string[] TextoRanking()
    {
        string[] lineas = new string[rankCantidad];
        for (int i = 0; i < rankCantidad; i++)
            lineas[i] = (i + 1) + ". " + rankNombres[i] + " - " + rankPuntos[i];
        return lineas;
    }
}
