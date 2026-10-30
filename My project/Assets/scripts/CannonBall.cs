using UnityEngine;
using UnityEngine.Rendering;

public class CannonBall : MonoBehaviour
{
    private float Speed = 5000;
    private Rigidbody rb;
    public GameObject ExplosionPrefab;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5f);
        rb.AddForce(transform.forward * Speed, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject, 2f);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
