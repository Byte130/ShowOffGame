using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{

    public Transform Player;
    public Transform orientation;
    public Transform PlayerObj;
    public Rigidbody rb;

    public float rotationSpeed;

    void Update()
    {
        //rotate orientation
        Vector3 ViewDir = Player.transform.position - new Vector3(transform.position.x, transform.position.y, transform.position.z);
        orientation.forward = ViewDir * rotationSpeed;

        //rotate player object
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput;   

        if (inputDir != Vector3.zero)
        {
            PlayerObj.forward = Vector3.Slerp(PlayerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }
    }
}
