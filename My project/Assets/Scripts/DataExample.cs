using System;
using UnityEngine;

[Flags]
public enum DAY
{
    None = 0,
    일 = 1 << 0,
    월 = 1 << 1,
    화 = 1 << 2,
    수 = 1 << 3,
    목 = 1 << 4,
    금 = 1 << 5,
    토 = 1 << 6
}

public enum JOB
{
    직장인, 프리랜서
}

public class DataExample : MonoBehaviour
{
    public string[] schedules;
    public DAY workDay;
    public JOB job;

    private void Start()
    {
        for(int i = 0; i < schedules.Length; i++)
        {
            Debug.Log(schedules[i]);
        }
        Debug.Log(workDay);
        Debug.Log(job);
    }
}
