using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject centerSpawner;
    CenterSpawnerControll csc;


    public GameObject objetosParaSpawnear;

    //Se generan cada 40 segundos
    public float tiempoDeSpawn = 0f;

    private float contadorDeTiempo = 0f;

    private void Update()
    {

        //Recupero el script central
        csc = centerSpawner.GetComponent<CenterSpawnerControll>();

        contadorDeTiempo += Time.deltaTime;

        //Si la cantidad de objetos es 0 se dejan de generar
        if (csc.cantidadActualDeObjetos > 0) {
            if (csc.cantidadActualDeObjetos < csc.maximaCantidadDeObjetos && contadorDeTiempo >= tiempoDeSpawn)
            {
                contadorDeTiempo = 0f;
                GameObject objetoSpawneado = objetosParaSpawnear;
                Instantiate(objetoSpawneado, transform.position, transform.rotation);

                //Aumentamos la cantidad de objetos
                csc.AumentarCantidadDeObjetos();
            }
        }
    }

}
