using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var lastPosition = this.transform.position;
        if (Input.GetKeyDown("a")) {
            this.transform.position = new Vector3(lastPosition.x - 1, lastPosition.y, lastPosition.z);
        } else if (Input.GetKeyDown("d")) {
            this.transform.position = new Vector3(lastPosition.x + 1, lastPosition.y, lastPosition.z);
        } else if (Input.GetKeyDown("w")){
            this.transform.position = new Vector3(lastPosition.x, lastPosition.y + 1, lastPosition.z);
        }else if (Input.GetKeyDown("s")){
            this.transform.position = new Vector3(lastPosition.x, lastPosition.y - 1, lastPosition.z);
        }else if (Input.GetKeyDown("z")){
            this.transform.position = new Vector3(lastPosition.x, lastPosition.y, lastPosition.z + 1);
        }else if (Input.GetKeyDown("x")){
            this.transform.position = new Vector3(lastPosition.x, lastPosition.y, lastPosition.z - 1);
        }

    }
}
