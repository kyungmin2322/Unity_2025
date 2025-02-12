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
class Potion : Item, ICountAble, IUseAble
{
    private int count;
    private string name;

    public int Count 
    { 
        get { return count; }
        set
        {
            if(count > 99)
            {
                Debug.Log("count�� 99���� �ִ��Դϴ�.");
                count = 99;
            }

            count = value;
        }
    }

    public string Name { get => name; set => name = value; }

    public void CountPlus() => Count++;

    public void Use()
    {
        Debug.Log($"{Name}�� ����߽��ϴ�.");
        Count--;
    }
}

public class InterfaceSample : MonoBehaviour
{
    Potion potion = new Potion();

    void Start()
    {
        // �ϼ��� Ŭ���� ����ϱ�
        potion.Count = 99;
        potion.Name = "���� ����";
        potion.CountPlus();
        potion.Use();
    }

    void Update()
    {
        
    }
}
