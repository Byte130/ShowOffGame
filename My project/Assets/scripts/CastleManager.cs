using System.Net.NetworkInformation;
using UnityEngine;
public class CastleManager : MonoBehaviour
{
    public states currentState = states.Idle;

    public GameObject PlayerCannon;
    public GameObject DrawBridge;

    public GameObject Cannon1;
    public GameObject FirePoint1;
    public GameObject Cannon2;
    public GameObject FirePoint2;
    public GameObject Cannon3;
    public GameObject FirePoint3;
    public GameObject Cannon4;
    public GameObject FirePoint4;

    public GameObject CannonBall;

    private float SpawnInterval = 5;
    private float SpawnTime = 0;

    public GameObject CastleSeesPlayerBox;

    void Update()
    {
        switch (currentState)
        {
            case states.Idle:
                if (CastleSeesPlayerBox.activeInHierarchy == false)
                {
                    currentState = states.Attack1;
                }

                SpawnTime += Time.deltaTime;
                if (SpawnTime >= SpawnInterval) {
                    SpawnTime = 0;

                    //Instantiate(CannonBall, FirePoint1.transform.position, FirePoint1.transform.rotation);
                    
                }
                break;

            case states.Attack1:
                Debug.Log("Attack1 Started");

                break;

            case states.Attack2:
                Debug.Log("Attack2 Started");
                break;


            case states.Reloading:
                Debug.Log("Reloading Started");
                break;

            case states.Dead:
                Debug.Log("Dead Started");
                break;
        }
    }

    public enum states
    {
        Idle,
        Attack1,
        Attack2, 
        Reloading,
        Dead,
    }
}