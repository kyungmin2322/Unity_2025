using System;
using UnityEngine;

public enum QuestType
{
    기본, 일일, 주간
}

[CreateAssetMenu(fileName = "Quest", menuName = "Quest/Quest")]
public class Quest : ScriptableObject
{
    public QuestType 퀘스트유형;
    public Reward 보상;
    public Requirement 요구조건;

    [Header("퀘스트 정보")]
    public string 제목;
    public string 목표;
    [TextArea] public string 설명;

    public bool 성공;
    public bool 진행상태;
}

[Serializable]
[CreateAssetMenu(fileName = "Requirement", menuName = "Quest/Requirement")]
public class Requirement : ScriptableObject
{
    public int 목표몬스터수;
    public int 현재누적몬스터수;
}

[Serializable]
[CreateAssetMenu(fileName = "Reward", menuName = "Quest/Reward")]
public class Reward : ScriptableObject
{
    public int 돈;
    public float 경험치;
}
