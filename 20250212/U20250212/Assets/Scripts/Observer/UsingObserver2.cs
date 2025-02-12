// �������̽� ISubject�� ������� �����ϴ� ������ ��� ����

using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UsingObserver2 : MonoBehaviour, ISubject
{
    // ������ �������� �����ϱ� ���� ������ ����Ʈ
    List<UObserver> observers = new List<UObserver>();

    public void Add(UObserver observer)
    {
        observers.Add(observer);
    }

    public void Notify()
    {
        // ������ ������ �ִ� ��� �������� ������� OnNotify() ����
        foreach(var observer in observers)
        {
            observer.OnNotify();
        }
    }

    public void Remove(UObserver observer)
    {
        if(observers.Count > 0)
        {
            observers.Remove(observer);
        }
    }

    void Start()
    {
        var observer1 = new Observer1();
        var observer2 = new Observer2();

        Add(observer1);
        Add(observer2);
    }
}
