using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Settings")]

    public float moveSpeed;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position += Vector3.left * GameManager.Instance.CalculateGameSpeed()
            * Time.deltaTime;

    }
}
