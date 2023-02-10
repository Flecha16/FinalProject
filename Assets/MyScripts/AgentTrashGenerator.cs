using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentTrashGenerator : MonoBehaviour
{
    public GameObject ContadorColision;
    contadorColisionesCentral ccl;
    public List<GameObject> objetos;
    private float radio = 5f;
    private float tiempoEntreGeneraciones = 10f;
    int cantidadMaxima = 125;

    void Start()
    {
        ccl = ContadorColision.GetComponent<contadorColisionesCentral>();
        StartCoroutine(Generar());
    }

    IEnumerator Generar()
    {
        //Se genera mientras no supere el límite

        while (ccl.contadorBotesAmarillos + ccl.contadorBotesRojos + ccl.contadorBotesVerdes < cantidadMaxima)
        {
            int indiceAleatorio = Random.Range(0, objetos.Count);
            //Vector3 posicionAleatoria = Random.insideUnitSphere * radio + transform.position;
            Instantiate(objetos[indiceAleatorio], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(tiempoEntreGeneraciones);
        }
    }
}
