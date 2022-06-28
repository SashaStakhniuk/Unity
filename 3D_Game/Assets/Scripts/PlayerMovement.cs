using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 15;
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("-> Inside cube OnTrigerEnter() \n");

    //    if (other.gameObject.tag == "Coin")
    //    {
    //        Debug.Log("-> COIN \n");
    //    }
    //}
}
