using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target;

    public float offsetX, offsetY, offsetZ;

    public float DelayTime = 5f;


    void Update()
    {
        Vector3 FixedPos = new Vector3(
            target.transform.position.x + offsetX,
            target.transform.position.y + offsetY,
            target.transform.position.z + offsetZ);
        transform.position = Vector3.Lerp(transform.position, FixedPos, Time.deltaTime * DelayTime);
    }
}
