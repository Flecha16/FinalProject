using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.XR;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class ContadorColision : MonoBehaviour
{
    public TextMeshProUGUI contadorAmarillo;
    public TextMeshProUGUI contadorRojo;
    public TextMeshProUGUI contadorVerde;
    private AudioSource fuenteAudio;
    public AudioClip sonidoColision;

    public GameObject contColisionesCentral;
    contadorColisionesCentral ccc;


    private void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();

        ccc = contColisionesCentral.GetComponent<contadorColisionesCentral>();
    }

    private void Update()
    {

        //Si se tiene 15 de cualquier tipo de basura se cambia de escena
        if (ccc.contadorBotesAmarillos >= 15 || ccc.contadorBotesRojos >= 15 || ccc.contadorBotesVerdes >= 15) {
            SceneManager.LoadScene("Second");
        }
        



    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "yellow")
        {
            ccc.aumentarContadorBotesAmarillos();
            contadorAmarillo.text = ccc.contadorBotesAmarillos.ToString();
            //Destruye el objeto
            Destroy(col.gameObject);
            fuenteAudio.PlayOneShot(sonidoColision);
        }
        if (col.gameObject.tag == "red")
        {
            ccc.aumentarContadorBotesRojos();
            contadorRojo.text = ccc.contadorBotesRojos.ToString();
            //Destruye el objeto
            Destroy(col.gameObject);
            fuenteAudio.PlayOneShot(sonidoColision);
        }
        if (col.gameObject.tag == "green")
        {
            ccc.aumentarContadorBotesVerdes();
            contadorVerde.text = ccc.contadorBotesVerdes.ToString();
            //Destruye el objeto
            Destroy(col.gameObject);
            fuenteAudio.PlayOneShot(sonidoColision);
        }
    }
}
