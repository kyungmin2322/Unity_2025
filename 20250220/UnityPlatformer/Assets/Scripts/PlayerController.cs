using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody;

    float axisH = 0.0f;
    public float speed = 3.0f;

    public float jump = 9.0f;
    public LayerMask groundLayer;
    bool goJump = false;
    bool onGround = false;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        axisH = Input.GetAxisRaw("Horizontal"); // 수평 이동

        if(axisH > 0.0f)
        {
            transform.localScale = new Vector2(1, 1);
        }
        else if(axisH < 0.0f)
        {
            // 벡터가 -로 잡히게 되면 좌우 반전
            transform.localScale = new Vector2(-1, 1);
        }

        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

	private void FixedUpdate()
	{
        // 지정한 두 점을 연결하는 가상의 선에
        // 게임 오브젝트가 접촉하는지를 조사하여
        // true 또는 false로 return 하는 함수

        // up은 Vector 기준 (0, 1, 0)이다.

        // (플레이어의 현재 pivot은 bottom)
        onGround = Physics2D.Linecast(transform.position,
            transform.position - ( transform.up * 0.1f ), groundLayer);

        // 지면 위에 있거나, 속도가 0이 아닌 경우
        if(onGround || axisH != 0)
        {
            rbody.linearVelocity = new Vector2(speed * axisH, rbody.linearVelocityY);
        }

        // 지면 위에 있는 상태에서 점프키가 눌린 경우
        if ( onGround && goJump )
        {
            // 플레이어가 가진 점프 수치 만큼 벡터 설계
            Vector2 jumpPw = new Vector2(0, jump);
            // 해당 위치로 힘을 가함
            rbody.AddForce(jumpPw, ForceMode2D.Impulse);

            goJump = false;
        }
	}

    private void Jump()
    {
        // 플래그 키는 작업
        goJump = true;
    }
}
