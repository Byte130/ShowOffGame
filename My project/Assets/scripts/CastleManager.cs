using System.Net.NetworkInformation;
using UnityEngine;
public class CastleManager : MonoBehaviour
{
    public states currentState = states.Idle;

    public GameObject PlayerCannon;
    public GameObject DrawBridge;
    public GameObject Arrow;

    public GameObject FirePoint1;
    public GameObject FirePoint2;
    public GameObject FirePoint3;
    public GameObject FirePoint4;

    public GameObject CannonBall;

    private float SpawnInterval = 3   ;
    private float SpawnTime = 0;

    private float ReloadTime = 40;
    private float ReloadTimer = 0;

    public GameObject CastleSeesPlayerBox;
    
    private void Start()
    {
        Arrow.SetActive(false);
    }

    void Update()
    {
        switch (currentState)
        {
            case states.Idle:
                if (CastleSeesPlayerBox.activeInHierarchy == false)
                {
                    currentState = states.Attack1;
                }

                  
                break;

            case states.Attack1:

                SpawnTime += Time.deltaTime;
                if (SpawnTime >= SpawnInterval) {
                    SpawnTime = 0;

                    Instantiate(CannonBall, FirePoint1.transform.position, FirePoint1.transform.rotation);
                    Instantiate(CannonBall, FirePoint2.transform.position, FirePoint2.transform.rotation);
                }

                ReloadTimer += Time.deltaTime;
                if (ReloadTimer >= ReloadTime)
                {
                    ReloadTimer = 0;
                    currentState = states.Reloading;
                }

                break;

            case states.Attack2:
                Debug.Log("Attack2 Started");
                break;


            case states.Reloading:

                Arrow.SetActive(true);
                

                break;

            case states.Dead:
                Arrow.SetActive(false);
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