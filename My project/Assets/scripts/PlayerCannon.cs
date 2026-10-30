using UnityEngine;

public class PlayerCannon : MonoBehaviour
{

    [SerializeField] GameObject FirePoint;
    [SerializeField] GameObject CannonBall;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(CannonBall, FirePoint.transform.position, FirePoint.transform.rotation);
        }
    }

}
