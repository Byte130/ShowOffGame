using UnityEngine;
using UnityEngine.Rendering;

public class CannonBall : MonoBehaviour
{
    private float Speed = 5000;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5f);
        rb.AddForce(transform.forward * Speed, ForceMode.Force);
    }

}
