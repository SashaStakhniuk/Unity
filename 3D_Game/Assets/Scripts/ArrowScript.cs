using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Arrow script is started!");

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, Mathf.Sin(Time.deltaTime) , 0);
       // transform.position = new Vector3(transform.position.x, Mathf.Sin(2*Time.fixedTime)/3, transform.position.z);
        transform.position = new Vector3(36, (float)1.35 + Mathf.Sin(2 * Time.fixedTime) / 3,44);

    }
}
