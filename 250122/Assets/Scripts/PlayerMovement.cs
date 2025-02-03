// 리지드 바디를 이용한 플레이어의 이동
using System;
using UnityEngine;

// 해당 기능을 통해 이 스크립트를 컴포넌트로써 사용할 경우,
// 적어놓은 컴포넌트를 요구하게 된다.
// 1. 해당 컴포넌트가 없는 오브젝트에 연결할 경우,
// 자동으로 연결을 진행 해준다.
// 2. 이 스크립트가 연결된 상태라면,
// 그 오브젝트는 대상의 컴포넌트를 제거할 수 없다.
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
                Debug.Log("점프");
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("골인!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            bIsJump = false;
        }
        Debug.Log("땅 밟음.");
    }
}
