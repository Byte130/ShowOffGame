using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.VersionControl.Asset;

public class EnemyCentipede : MonoBehaviour
{
    public states currentState = states.idle;

    public Transform Position;
    [SerializeField] private Rigidbody rb;

    public float centiLeftSpeed = 10;
    public float centiRightSpeed = -10;

    private void Start()
    {
        rb.AddForce(Vector2.left * centiLeftSpeed, ForceMode.VelocityChange); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LeftWall"))
        {
            rb.AddForce(Vector2.left * centiRightSpeed, ForceMode.VelocityChange);
        }

        if (collision.gameObject.CompareTag("RightWall"))
        {
            rb.AddForce(Vector2.left * centiLeftSpeed, ForceMode.VelocityChange);
        }
    }

    void Update()
    {
        switch (currentState)
        {
            case states.idle:

            break;
        }
    }


 public enum states
 {
    idle,
 }

}   