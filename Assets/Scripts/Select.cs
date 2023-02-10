using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    
    public GameObject canvasC;
    public GameObject canvasI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void correctoA(){
        canvasC.SetActive(true);
    }

    public void correctoC(){
        canvasC.SetActive(false);
    }

    public void incorrectoA(){
        canvasI.SetActive(true);
    }

    public void incorrectoC(){
        canvasI.SetActive(false);
    }
}
