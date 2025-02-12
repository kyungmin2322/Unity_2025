// ������ ����(Observer)
// �� ������Ʈ�� ���°� ����Ǹ�, �� ��ü�� �����ϰ� �ִ� �ٸ� ��ü�鿡��
// �ڵ����� ������ ���ŵǴ� ���� ���

// abstract class�� �������̽� ó�� �޼ҵ忡 ���� ������ ������ �� �ִ� Ŭ����

using UnityEngine;

/// <summary>
/// �������� ���� ����, Ȱ���� �����ϱ� ���� �������̽�
/// </summary>
public interface ISubject
{
    // ������ ���
    void Add(UObserver observer);

    // ������ ����
    void Remove(UObserver observer);

    // ����
    void Notify();
}

public abstract class UObserver
{
    public abstract void OnNotify();
}

public class Observer1 : UObserver
{
    public override void OnNotify()
    {
        Debug.Log("UObserver action #1");
    }
}
public class Observer2 : UObserver
{
    public override void OnNotify()
    {
        Debug.Log("UObserver action #2");
    }
}
