using UnityEngine;

public class LookAtt : MonoBehaviour
{

    public GameObject Target;

    void Update()
    {
        Vector3 Look = transform.InverseTransformPoint(Target.transform.position);
        float Angle = Mathf.Atan2(Look.x, Look.z) * Mathf.Rad2Deg;

        transform.Rotate(Angle, Angle, Angle);
    }
}
