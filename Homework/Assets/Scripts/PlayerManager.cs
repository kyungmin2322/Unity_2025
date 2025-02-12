using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerManager : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�
    private Rigidbody rigidbody;

    float hAxis, vAxis;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // �̵� ���� �� �ӵ� ���
        Vector3 movement = new Vector3(hAxis, 0, vAxis).normalized;
        float movementSpeed = movement.magnitude;

        if(movementSpeed > 0.1f)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);

            rigidbody.MoveRotation(Quaternion.Slerp(transform.rotation, newRotation, 0.2f));

            rigidbody.MovePosition(transform.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
