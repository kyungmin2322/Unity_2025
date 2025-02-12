using UnityEngine;

public interface Enemy
{
    void Action();
}

// �������̽��� �߻� Ŭ����(abstract class) ������
// 1. ����� ������ ������ ����� �ſ� ���� ����ȴ�.
// 2. 

public class Goblin : Enemy
{
    public void Action()
    {
        Debug.Log("����� ������ �մϴ�.");
    }
}

public class Slime : Enemy
{
    public void Action()
    {
        Debug.Log("�������� ���� ������ �մϴ�.");
    }
}

public class Wolf : Enemy
{
    public void Action()
    {
        Debug.Log("���밡 �����⸦ �����մϴ�.");
    }
}