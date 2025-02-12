// 유니티의 인터페이스(interface)
// 공통적인 특징에 대한 관리 구현 시 효과적이다.
// 함수나 프로퍼티 등의 정의를 구현 없이 진행할 수 있다.
// 인터페이스는 명시만 하기 때문에, 사용하기 위해서는
// 반드시 상속을 통한 재구현으로 진행한다.


using UnityEngine;

public interface ICountAble
{
    // int a = 0; 인터페이스 내에서는 선언만 진행한다.

    int Count { get; set; }

    void CountPlus();
}

public interface IUseAble
{
    void Use();
}

// 인터페이스는 상속처럼 등록할 수 있다.
// 인터페이스의 경우 다중 상속이 가능하다.
class Potion : ICountAble, IUseAble
{
    public int Count { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void CountPlus()
    {
        throw new System.NotImplementedException();
    }

    public void Use()
    {
        throw new System.NotImplementedException();
    }
}

public class InterfaceSample : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
