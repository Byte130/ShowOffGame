using System.Net.NetworkInformation;
using UnityEngine;
public class CastleManager : MonoBehaviour
{
    public states currentState = states.Idle;

    public int Lives = 2;
    public bool IsReloading = false;

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
        if (Lives <= 0)
        {
            currentState = states.Dead;
        }

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
                SpawnTime += Time.deltaTime;
                if (SpawnTime >= SpawnInterval)
                {
                    SpawnTime = 0;

                    Instantiate(CannonBall, FirePoint1.transform.position, FirePoint1.transform.rotation);
                    Instantiate(CannonBall, FirePoint2.transform.position, FirePoint2.transform.rotation);
                    Instantiate(CannonBall, FirePoint3.transform.position, FirePoint3.transform.rotation);
                    Instantiate(CannonBall, FirePoint4.transform.position, FirePoint4.transform.rotation);
                }

                ReloadTimer += Time.deltaTime;
                if (ReloadTimer >= ReloadTime)
                {
                    ReloadTimer = 0;
                    currentState = states.Reloading;
                }

                break;


            case states.Reloading:

                Arrow.SetActive(true);
                IsReloading = true;

                if (IsReloading == false) 
                {
                    Arrow.SetActive(false);
                    currentState = states.Attack2;
                }
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CannonBall"))
        {
            Lives -= 1;
            IsReloading = false;
        }
    }
}

