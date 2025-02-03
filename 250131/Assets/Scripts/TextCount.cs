// 텍스트에 카운트를 출력하는 기능을 구현한다.
// 카운트는 계속 1씩 증가하는 형태로 처리한다.

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextCount : MonoBehaviour
{
    private int iCount;
    public Text tCountText;

    void Start()
    {
        // 코루팅 사용 방법

        // StartCoroutine("함수의 이름(IEnumerator 형태의 함수)");
        // 1. 문자열을 통해 함수를 찾아서 실행하는 방식
        // 오타가 발생해도 오류가 발생하진 않음.
        // 하지만 제대로 실행되지 않음.
        // StopCoroutine()을 통해 외부에서 중지하는 것이 가능하다.

        // 중단 가능, 효율 보통
        /*StartCoroutine("CountPlus");
        StopCoroutine("CountPlus");

        // StartCoroutine(함수의 이름());
        // 2. 해당 함수를 호출해 실행 결과를 반환받는 형태
        // 오타 발생 시 오류 체크 가능
        // 이 방식으로는 StopCoroutine()을 통한 외부에서의 중기 기능을 사용할 수 없다.

        // 중단 불가능, 효율 좋음
        StartCoroutine(CountPlus());*/


        StartCoroutine("CountPlus");
    }

    IEnumerator CountPlus()
    {
        while(true)
        {
            iCount++;
            tCountText.text = iCount.ToString("N0");
            // C#의 ToString()을 통해 문자 형태로 변형이 가능
            // N0는 숫자 3자리 간격으로 ,를 표시하는 format이다.
            // 1000 -> 1,000

            yield return new WaitForSeconds(0.1f);
            // 다음 동작으로 넘어간다.
        }

        /*Debug.Log("아아 마이크 테스트");
        yield return new WaitForSeconds(1);

        // yield는 일시적으로 CPU의 권한을 다른 함수에 위임하는 키워드이다.

        Debug.Log("밥만 먹고 올게");
        yield return new WaitForSeconds(5);
        Debug.Log("다시 일을 해볼까?");*/
    }
}
