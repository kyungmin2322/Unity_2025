// ����Ƽ�� �������̽�(interface)
// �������� Ư¡�� ���� ���� ���� �� ȿ�����̴�.
// �Լ��� ������Ƽ ���� ���Ǹ� ���� ���� ������ �� �ִ�.
// �������̽��� ��ø� �ϱ� ������, ����ϱ� ���ؼ���
// �ݵ�� ����� ���� �籸������ �����Ѵ�.


using UnityEngine;

public interface ICountAble
{
    // int a = 0; �������̽� �������� ���� �����Ѵ�.

    int Count { get; set; }

    void CountPlus();
}

public interface IUseAble
{
    void Use();
}

// �������̽��� ���ó�� ����� �� �ִ�.
// �������̽��� ��� ���� ����� �����ϴ�.
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
