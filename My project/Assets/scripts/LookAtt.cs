using UnityEngine;

public class LookAtt : MonoBehaviour
{
    public GameObject Target;

    public float RotationSpeed = 5f;

    void Update()
    {
        if (Target == null) return;

        Vector3 direction = Target.transform.position - transform.position;
        if (direction.sqrMagnitude < 0.000001f) return;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, RotationSpeed * Time.deltaTime);

    }
}