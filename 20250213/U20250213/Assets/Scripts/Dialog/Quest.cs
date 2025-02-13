using System;
using UnityEngine;

public enum QuestType
{
    �⺻, ����, �ְ�
}

[CreateAssetMenu(fileName = "Quest", menuName = "Quest/Quest")]
public class Quest : ScriptableObject
{
    public QuestType ����Ʈ����;
    public Reward ����;
    public Requirement �䱸����;

    [Header("����Ʈ ����")]
    public string ����;
    public string ��ǥ;
    [TextArea] public string ����;

    public bool ����;
    public bool �������;
}

[Serializable]
[CreateAssetMenu(fileName = "Requirement", menuName = "Quest/Requirement")]
public class Requirement : ScriptableObject
{
    public int ��ǥ���ͼ�;
    public int ���紩�����ͼ�;
}

[Serializable]
[CreateAssetMenu(fileName = "Reward", menuName = "Quest/Reward")]
public class Reward : ScriptableObject
{
    public int ��;
    public float ����ġ;
}
