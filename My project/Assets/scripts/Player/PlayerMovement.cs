using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody Rigidbody;

    public InputActionReference flashlight;

    public InputActionReference move;

    private Vector2 dir;

    private void Flashlight(InputAction.CallbackContext flashlight)
    {
        Debug.Log("Flashlight toggled");
    }
     
    private void OnEnable()
    {
        flashlight.action.started += Flashlight;
    }
    private void OnDisable()
    {
        flashlight.action.started -= Flashlight;
    }

    void Start()
    {
        
    }


    void Update()
    {
        dir = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Rigidbody.MovePosition(Rigidbody.position + new Vector3(dir.x, 0, dir.y) * speed * Time.fixedDeltaTime);
    }
}