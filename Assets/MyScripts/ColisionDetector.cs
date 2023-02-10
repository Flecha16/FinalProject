using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDetector : MonoBehaviour
{
    public AudioClip sonidoColision;
    private AudioSource fuenteAudio;
    private Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {


        fuenteAudio = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            fuenteAudio.PlayOneShot(sonidoColision);
            rigidBody.constraints = RigidbodyConstraints.FreezeAll;


            

            Invoke("Kill", 2f);

        }
    }


    void Kill()
    {
        //csc.DisminuirCantidadDeObjetos();
        Destroy(this.gameObject);
    }
}
