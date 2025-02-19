using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Monster : MonoBehaviour
{
    public float monster_speed;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 영점 기준으로 시선 변경
        transform.LookAt(Vector3.zero);

        // 영점 기준으로 몬스터의 속도만큼 앞으로 이동
        transform.position = Vector3.MoveTowards(transform.position,
            Vector3.zero, Time.deltaTime * monster_speed);

        SetMotionChange("isMOVE", true);
    }

    private void SetMotionChange(string motion_name, bool param)
    {
        animator.SetBool(motion_name, param);
    }
}
