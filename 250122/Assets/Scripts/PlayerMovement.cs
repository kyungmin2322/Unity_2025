// ������ �ٵ� �̿��� �÷��̾��� �̵�
using System;
using UnityEngine;

// �ش� ����� ���� �� ��ũ��Ʈ�� ������Ʈ�ν� ����� ���,
// ������� ������Ʈ�� �䱸�ϰ� �ȴ�.
// 1. �ش� ������Ʈ�� ���� ������Ʈ�� ������ ���,
// �ڵ����� ������ ���� ���ش�.
// 2. �� ��ũ��Ʈ�� ����� ���¶��,
// �� ������Ʈ�� ����� ������Ʈ�� ������ �� ����.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public int iA = 10;

    public float fSpeed = 2.0f;

    public float dJump_force = 3.5f;

    public bool bIsJump = false;

    private Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float fX = Input.GetAxisRaw("Horizontal");
        float fY = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3(fX, fY, 0) * fSpeed * Time.deltaTime;

        transform.position += velocity;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!bIsJump)
            {
                bIsJump = true;
                rigid.AddForce(Vector3.up * dJump_force, ForceMode2D.Impulse);
                Debug.Log("����");
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("����!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            bIsJump = false;
        }
        Debug.Log("�� ����.");
    }
}
