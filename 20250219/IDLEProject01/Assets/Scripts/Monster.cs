using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Monster : MonoBehaviour
{
    Animator animator;

    public float monster_speed;
    public float rate = 0.5f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 영점 기준으로 시선 변경
        transform.LookAt(Vector3.zero);

        // 간격 설정
        float target_distance = Vector3.Distance(transform.position,
            Vector3.zero);

        if (target_distance <= rate) // 간격 거리와 가까워지면 이동 중지
        {
            SetMotionChange("isMOVE", false);
        }
        else // 일반적인 경우에는 움직임을 진행
        {
            // 영점 기준으로 몬스터의 속도만큼 앞으로 이동
            transform.position = Vector3.MoveTowards(transform.position,
                Vector3.zero, Time.deltaTime * monster_speed);

            SetMotionChange("isMOVE", true);
        }
    }

    private void SetMotionChange(string motion_name, bool param)
    {
        animator.SetBool(motion_name, param);
    }
}
