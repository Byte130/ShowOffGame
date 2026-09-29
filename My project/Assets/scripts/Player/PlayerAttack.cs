using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{

    public GameObject PlayerSword;
    bool swordActive = false;

    void Start()
    {
        PlayerSword.SetActive(false);
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            PlayerSword.SetActive(true);
            swordActive = true;
        }

        if (swordActive == true) 
        {
            PlayerSword.SetActive(false);
        }
    }
}