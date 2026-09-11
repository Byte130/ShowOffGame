using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerAlternateMovement : MonoBehaviour
{

    private Rigidbody rb;
    private float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(speed, 0, 0);


        }
    }
}
