using System;
using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public enum QuestType
{
    �⺻, ����, �ϰ�, �ְ�
}

public enum QuestList
{
    ���, ����
}

[CreateAssetMenu(fileName = "Quest", menuName = "Quest/Quest")]
public class Quest : ScriptableObject
{
    public QuestType ����Ʈ����1;
    public QuestList ����Ʈ����2;
    public Reward ����;
    public Requirement �䱸����;

    [Header("����Ʈ ����")]
    public string ����;
    public string ��ǥ;
    [TextArea] public string ����;

    public bool ����Ʈ�Ϸ�;
    public bool ������;
}

[Serializable]
[CreateAssetMenu(fileName = "Requirement", menuName = "Quest/Requirement")]
public class Requirement : ScriptableObject
{
    public int ��ǥ����;
    public int ��������;
}

[Serializable]
[CreateAssetMenu(fileName = "Reward", menuName = "Quest/Reward")]
public class Reward : ScriptableObject
{
    public int ��;
    public float ����ġ;
}