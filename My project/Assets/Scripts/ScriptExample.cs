using UnityEngine;


[AddComponentMenu("CustomUtility/ScriptExample")]
public class ScriptExample : MonoBehaviour
{
    [Range(1, 99)]
    public int level;

    [Range(0, 100)]
    public int volume;

    [Header("�÷��̾��� �̸�")]
    public string playerName;

    [TextArea]
    public string talk01;

    [TextArea(1, 3)]
    public string talk02;

    [TextArea(5, 7)]
    public string talk03;

    [Tooltip("üũ�Ǹ� ���� �������� �ǹ��մϴ�.")]
    public bool isDead = true;

    [ContextMenu("HelloEveryone")]
    void HelloEveryone()
    {
        Debug.Log("�����е� ��� �ȳ��ϼ���!!");
    }

    void HelloSomeone(string who)
    {
        Debug.Log($"{who}�� �ȳ��ϼ���!");
    }
}
