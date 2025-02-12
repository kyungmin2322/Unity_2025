// ����Ƽ���� �������ִ� ��������Ʈ
// 1. using System; �ʿ�

using System;
using UnityEngine;

public class UnityDelegateSample : MonoBehaviour
{
    // 1) Acion delegate
    //  ��. ��ȯ Ÿ���� ���� ���� ������ �븮��
    Action action;

    //  ��. �Ű������� �ִ� ���
    //  Action<T> delegate��;
    Action<int> action1;

    Action<string, int> action2;

    // 2) Func delegate
    // ��ȯ Ÿ���� ������ ������ �븮��
    Func<int> func01;

    Func<int, int, int> func02;
    // ��ȯ Ÿ���� int, �Ű������� (int, int)

    void Start()
    {
        action = Sample;
        action();
        action1 = Sample1;
        action2 = Sample3;

        // �븮���� ���, �ٷ� ����� �����ؼ� ����ϴ� �͵� �����ϴ�.
        func01 = () => 10; // ���ٽ� ǥ����

        // ����� ���
        // Func<T> �̸� = (�Ű����� �ۼ� ��ġ) => ��;
        Func<int> test = () => 25;

        // �Ű������� �����ϴ� ���
        func02 = (a, b) => a + b;

        // ���� ������ ����� �ϴ� ���
        func02 = (a, b) =>
        {
            if (a > b)
            {
                a = b;
            }
            return a + b;
        };
    }

    // �����ε�(Overloading) ����
    // �Ϲ������� �Լ����� �����ϰ� �����Ѵ�.
    // ������, ���� ������ ��ų ��� ���� �̸��� �޼ҵ带 ����� �� �ִ�.

    // �Ű������� ����, Ÿ��, ������ �ٸ��ٸ� ���� �̸����� �޼ҵ� ���ǰ� �����ϴ�.

    // �����ε� ����� ���� �ణ�� ��Ȳ�� ���� �Ź� �޼ҵ��� �̸��� ������� �ʿ� ����
    // Ư�� ����� �����ϴ� ���� �̸��� �޼ҵ带 ����� �̸��� ������ �� �ִ�.

    // �������̵�(Overriding)
    // �θ� Ŭ�����κ��� ��ӹ��� �޼ҵ带 �ڽ� Ŭ�������� �������ϴ� ����
    // �������̽�, abstract class �� ���� ����(����)�� �Ǿ��ִ� �޼ҵ带 ���޹��� �����,
    // ���������� �����ؾ� �Ѵ�.

    // ���� Ŭ�������� ���ϴ� ��ɿ� ���� ����
    // �������̽�, abstract class �� ���� �������� Ʋ�� ���� ������ �ڵ� ���� ����
    // �ϳ��� ��ü�� ���� ���¸� ǥ���ϴ� ������ �������� ȿ������.

    public void Sample() { }
    public void Sample1(int a) { }
    public int Sample2() { return 0; }
    public void Sample3(string a, int b) { }
}
