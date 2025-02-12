using UnityEngine;

public class DelegateSample : MonoBehaviour
{
    // ��������Ʈ(delegate)
    // �Լ��� ������ �� �ִ� �Լ�, �Ϲ������� �븮�ڶ�� �θ���.
    // �ش� �������� �Լ��� ���ԵǾ� �����Ƿ�, �ش� ������ �����ϸ�
    // ������ �Լ��� ����Ǵ� ����� ������ �ִ�.

    // ���� ���
    // ���� ������ delegate Ÿ�� ��������Ʈ��(�Ű�����)

    delegate void DelegateTest();

    void Start()
    {
        // ��������Ʈ ���
        // ��������Ʈ�� ������ = new ��������Ʈ��(�Լ���)
        DelegateTest dt = new DelegateTest(Attack);

        // �Լ�ó�� ȣ���Ѵ�.
        dt();

        // ���� ����
        // ������ = �Լ���;
        dt = Guard;

        dt();

        // �Ϲ����� �Լ� ȣ���� �ƴ� delegate ������ ���� ��ü �Ҵ��ϴ� ����?
        
        // 1. delegate�� �Լ��� �ƴ� Ÿ���̱� ����
        // = �Ű������ε� Ȱ���� �����ϰ�, return Ÿ������ ����ִ� �͵� ����

        // 2. ��������Ʈ ü��(delegate Chain)
        // delegate�� +=�� ���� �븮�� �Լ��� �� �߰��� �� �ְ�,
        // -=�� ���� �븮�� �Լ��� �����ϴ� �͵� �����ϴ�.
    }

    void UseDelegate(DelegateTest dt)
    {
        dt();
    }

    DelegateTest Selection(int value)
    {
        if (value == 0) return Attack;
        else if (value == 1) return Guard;
        else if (value == 2) return MoveLeft;
        else return MoveRight;
    }

    void Attack() => Debug.Log("����");
    void Guard() => Debug.Log("���");
    void MoveLeft() => Debug.Log("���� �̵�");
    void MoveRight() => Debug.Log("������ �̵�");
}
