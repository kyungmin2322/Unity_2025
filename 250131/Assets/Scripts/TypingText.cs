using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypingText : MonoBehaviour
{
    public Text tMessage; // 타이핑할 텍스트
    [SerializeField] [TextArea] private string sContext; // 출력할 내용
    [SerializeField] private float fDelay = 0.2f; // 읽는 속도

    void Start()
    {
        
    }

    public void OnMessageButonClick()
    {
        StartCoroutine("Typing");
    }

    /// <summary>
    /// 2배속 기능
    /// </summary>
    public void ByTwo()
    {
        if (fDelay == 0.2f) fDelay = 0.1f;
        else fDelay = 0.2f;
    }

    IEnumerator Typing()
    {
        tMessage.text = ""; // 현재 화면의 메세지를 지운다.

        int iTyping_Count = 0; // 타이핑 카운트를 0으로 설정

        // 현재 카운트가 컨텐츠의 길이와 다르다면
        while(iTyping_Count != sContext.Length)
        {
            if(iTyping_Count < sContext.Length)
            {
                tMessage.text += sContext[iTyping_Count].ToString();
                // 현재 카운트에 해당하는 단어 하나를 메세지 텍스트 UI에 전달한다.
                iTyping_Count++;
                // 카운트를 1 증가시킨다.
            }
            yield return new WaitForSeconds(fDelay);
            // 현재의 딜레이만큼 대기한다.
        }
    }
}
