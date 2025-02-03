using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypingText : MonoBehaviour
{
    public Text tMessage; // Ÿ������ �ؽ�Ʈ
    [SerializeField] [TextArea] private string sContext; // ����� ����
    [SerializeField] private float fDelay = 0.2f; // �д� �ӵ�

    void Start()
    {
        
    }

    public void OnMessageButonClick()
    {
        StartCoroutine("Typing");
    }

    /// <summary>
    /// 2��� ���
    /// </summary>
    public void ByTwo()
    {
        if (fDelay == 0.2f) fDelay = 0.1f;
        else fDelay = 0.2f;
    }

    IEnumerator Typing()
    {
        tMessage.text = ""; // ���� ȭ���� �޼����� �����.

        int iTyping_Count = 0; // Ÿ���� ī��Ʈ�� 0���� ����

        // ���� ī��Ʈ�� �������� ���̿� �ٸ��ٸ�
        while(iTyping_Count != sContext.Length)
        {
            if(iTyping_Count < sContext.Length)
            {
                tMessage.text += sContext[iTyping_Count].ToString();
                // ���� ī��Ʈ�� �ش��ϴ� �ܾ� �ϳ��� �޼��� �ؽ�Ʈ UI�� �����Ѵ�.
                iTyping_Count++;
                // ī��Ʈ�� 1 ������Ų��.
            }
            yield return new WaitForSeconds(fDelay);
            // ������ �����̸�ŭ ����Ѵ�.
        }
    }
}
