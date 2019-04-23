using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    public float speed;
    public float hspeed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        
    }

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            
        }
    }*/

    void HardMode()
    {
        rb.velocity = transform.forward * hspeed;
    }


}