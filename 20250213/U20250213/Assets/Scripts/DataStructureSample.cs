using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructureSample : MonoBehaviour
{
    // strung ������ ���� ������ �� �ִ� ť
    public Queue<string> stringQueue = new Queue<string>();

    private void Start()
    {
        // 1. ť�� ������ �߰�
        stringQueue.Enqueue("���� �����ּ���.");
        stringQueue.Enqueue("���� �� �ΰ���?");
        stringQueue.Enqueue("�ٳ��� ���� 20���� �ʿ��ؿ�.");
        stringQueue.Enqueue("���͵帱�Կ�.");
        stringQueue.Enqueue("�����մϴ�.");

        // 2. ù ��° ������ ��ȸ
        foreach(string dialog in stringQueue)
        {
            // ť�� ����� ���� �� ���� ���� return�Ѵ�.
            Debug.Log(stringQueue.Peek());
        }

        // 3. ť�� ������ ����
        // ť�� ����� ���� �� ���� ���� return�Ѵ�.
        // �߰������� �� ���� ���� �����Ѵ�.
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
    }
}
