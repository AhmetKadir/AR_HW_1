using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * Time.deltaTime * 1);

        //if (transform.position.x > 1)
        //{
        //    transform.position = new Vector3(-1, transform.position.y, transform.position.z);
        //}

        //if (transform.position.x < -1)
        //{
        //    transform.position = new Vector3(1, transform.position.y, transform.position.z);
        //}

        // rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.right * Time.deltaTime * 90);

        // rotate the object around its local Y axis at 1 degree per second
        transform.Rotate(Vector3.up * Time.deltaTime * 90);


    }
}
