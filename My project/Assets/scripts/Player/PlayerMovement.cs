using UnityEngine;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour
{
    [SerializeField] public Rigidbody Rb;
    [SerializeField] public float speed = 999;
    [SerializeField] public float turnSpeed = 100;

    private Vector2 dir;

    [SerializeField] public InputActionReference flashlight;
    [SerializeField] public InputActionReference move;

    [SerializeField] public Transform cam;

    private void Flashlight(InputAction.CallbackContext obj)
    {
        Debug.Log("Flash");
    }

    private void OnEnable()
    {
        flashlight.action.started += Flashlight;
    }

    private void OnDisable()
    {
        flashlight.action.started -= Flashlight;
    }

    void Update()
    {
        dir = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 forward = cam.forward;
        Vector3 right = cam.right;


        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDir = forward * dir.y + right * dir.x;

        Vector3 velocity = moveDir * speed;
        velocity.y = Rb.linearVelocity.y;
        Rb.linearVelocity = velocity;

        if (moveDir.sqrMagnitude > 0.01f)
        {
            Quaternion targetRot = Quaternion.LookRotation(moveDir);

            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                targetRot,
                turnSpeed * Time.deltaTime
            );
        }
    }
}