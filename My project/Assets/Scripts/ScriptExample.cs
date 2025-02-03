using UnityEngine;


[AddComponentMenu("CustomUtility/ScriptExample")]
public class ScriptExample : MonoBehaviour
{
    [Range(1, 99)]
    public int level;

    [Range(0, 100)]
    public int volume;

    [Header("플레이어의 이름")]
    public string playerName;

    [TextArea]
    public string talk01;

    [TextArea(1, 3)]
    public string talk02;

    [TextArea(5, 7)]
    public string talk03;

    [Tooltip("체크되면 죽은 상태임을 의미합니다.")]
    public bool isDead = true;

    [ContextMenu("HelloEveryone")]
    void HelloEveryone()
    {
        Debug.Log("여러분들 모두 안녕하세요!!");
    }

    void HelloSomeone(string who)
    {
        Debug.Log($"{who}님 안녕하세요!");
    }
}
