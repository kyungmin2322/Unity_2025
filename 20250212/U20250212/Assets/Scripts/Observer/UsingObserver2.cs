// 인터페이스 ISubject를 기반으로 설계하는 옵저버 사용 예제

using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UsingObserver2 : MonoBehaviour, ISubject
{
    // 옵저버 여러개를 관리하기 위한 옵저버 리스트
    List<UObserver> observers = new List<UObserver>();

    public void Add(UObserver observer)
    {
        observers.Add(observer);
    }

    public void Notify()
    {
        // 옵저버 묶음에 있는 모든 옵저버를 대상으로 OnNotify() 진행
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
