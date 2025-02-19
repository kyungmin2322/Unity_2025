using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerManager : MonoBehaviour
{
    public GameManager gameManager;

    public float moveSpeed = 5f; // 이동 속도

    private Rigidbody rigidbody;

    float hAxis, vAxis;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hAxis = gameManager.isAction ? 0 : Input.GetAxis("Horizontal");
        vAxis = gameManager.isAction ? 0 : Input.GetAxis("Vertical");

        bool hDown = gameManager.isAction ? false : Input.GetButtonDown("Horizontal");
        bool vDown = gameManager.isAction ? false : Input.GetButtonDown("Vertical");
        bool hUp = gameManager.isAction ? false : Input.GetButtonUp("Horizontal");
        bool vUp = gameManager.isAction ? false : Input.GetButtonUp("Vertical");
    }

    private void FixedUpdate()
    {
        // 이동 방향 및 속도 계산
        Vector3 movement = new Vector3(hAxis, 0, vAxis).normalized;
        
        float movementSpeed = movement.magnitude;

        if (movementSpeed > 0.1f)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);
            
            rigidbody.MoveRotation(Quaternion.Slerp(transform.rotation, newRotation, 0.2f));
            rigidbody.MovePosition(transform.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}