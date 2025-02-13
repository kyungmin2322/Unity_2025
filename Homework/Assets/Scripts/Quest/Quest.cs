using System;
using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public enum QuestType
{
    기본, 직업, 일간, 주간
}

public enum QuestList
{
    사냥, 수집
}

[CreateAssetMenu(fileName = "Quest", menuName = "Quest/Quest")]
public class Quest : ScriptableObject
{
    public QuestType 퀘스트유형1;
    public QuestList 퀘스트유형2;
    public Reward 보상;
    public Requirement 요구조건;

    [Header("퀘스트 정보")]
    public string 제목;
    public string 목표;
    [TextArea] public string 설명;

    public bool 퀘스트완료;
    public bool 진행중;
}

[Serializable]
[CreateAssetMenu(fileName = "Requirement", menuName = "Quest/Requirement")]
public class Requirement : ScriptableObject
{
    public int 목표개수;
    public int 누적개수;
}

[Serializable]
[CreateAssetMenu(fileName = "Reward", menuName = "Quest/Reward")]
public class Reward : ScriptableObject
{
    public int 돈;
    public float 경험치;
}