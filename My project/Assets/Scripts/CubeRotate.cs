using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float x;
    public float z;
    private int sample;

    void Start()
    {
        sample = 10;
        Debug.Log(sample);
    }

    void Update()
    {
        transform.Rotate(new Vector3(x, 0, z));
    }
}
