using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorColisionesCentral : MonoBehaviour
{

    public int contadorBotesAmarillos = 0;
    public int contadorBotesRojos = 0;
    public int contadorBotesVerdes = 0;


    public void aumentarContadorBotesAmarillos() {
        contadorBotesAmarillos++;
    }

    public void aumentarContadorBotesRojos()
    {
        contadorBotesRojos++;
    }

    public void aumentarContadorBotesVerdes()
    {
        contadorBotesVerdes++;
    }

    public void disminuirContadorBotesAmarillos()
    {
        contadorBotesAmarillos--;
    }

    public void disminuirContadorBotesRojos()
    {
        contadorBotesRojos--;
    }

    public void disminuirContadorBotesVerdes()
    {
        contadorBotesVerdes--;
    }
}
