using UnityEngine;
using UnityEngine.Rendering;

public class CannonBall : MonoBehaviour
{

    private float Speed = 100f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.forward * Speed, ForceMode.Force);
    }

}
