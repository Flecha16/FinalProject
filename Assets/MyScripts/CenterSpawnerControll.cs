using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CenterSpawnerControll : MonoBehaviour
{
    public GameObject[] objetosParaSpawnear;
    public int cantidadActualDeObjetos = 10;

    public int maximaCantidadDeObjetos = 25;

    public TextMeshProUGUI contadorKarts;


    public void DisminuirCantidadDeObjetos()
    {
        if (cantidadActualDeObjetos > 0)
        {
            cantidadActualDeObjetos--;

            contadorKarts.text = cantidadActualDeObjetos.ToString();
        }
    }

    public void AumentarCantidadDeObjetos()
    {
        cantidadActualDeObjetos++;
        contadorKarts.text = cantidadActualDeObjetos.ToString();
    }
}
