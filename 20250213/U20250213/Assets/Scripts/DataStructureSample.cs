using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructureSample : MonoBehaviour
{
    // strung 형태의 값만 저장할 수 있는 큐
    public Queue<string> stringQueue = new Queue<string>();

    private void Start()
    {
        // 1. 큐에 데이터 추가
        stringQueue.Enqueue("저를 도와주세요.");
        stringQueue.Enqueue("무슨 일 인가요?");
        stringQueue.Enqueue("바나나 껍질 20개가 필요해요.");
        stringQueue.Enqueue("도와드릴게요.");
        stringQueue.Enqueue("감사합니다.");

        // 2. 첫 번째 데이터 조회
        foreach(string dialog in stringQueue)
        {
            // 큐에 저장된 가장 맨 앞의 값을 return한다.
            Debug.Log(stringQueue.Peek());
        }

        // 3. 큐의 데이터 삭제
        // 큐에 저장된 가장 맨 앞의 값을 return한다.
        // 추가적으로 맨 앞의 값을 제거한다.
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
    }
}
