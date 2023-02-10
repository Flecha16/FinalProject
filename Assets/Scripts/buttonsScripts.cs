using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsScripts : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrirInstagram() {
        Application.OpenURL("https://www.instagram.com/flecha.16/");
    }

    public void abrirFacebook()
    {
        Application.OpenURL("https://www.facebook.com/Flecha16.7");
    }

    public void abrirLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/juan-sebastian-calvopina/");
    }

    public void activarCanva() {
        canvas.SetActive(true);
    }
    public void desactivarCanva()
    {
        canvas.SetActive(false);
    }
}
