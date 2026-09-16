using UnityEngine;

public class DamageDetection : MonoBehaviour
{

    public float Health = 10;
    public bool Dead = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeathPit"))
        {
            Health = 0;


        }
    }

    private void Update()
    {
        if (Health > 0) 
        {
          Dead = true;
            Debug.Log("Player died");
        }
    }

}
