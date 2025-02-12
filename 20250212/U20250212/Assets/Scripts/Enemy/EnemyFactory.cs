using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public enum ENEMYTYPE
    {
        Goblin,
        Slime,
        Wolf
    }
    /// <summary>
    /// Factory���� �ٷ�� ������ ���¸� return�ϴ� �ڵ�
    /// </summary>
    /// <param name="type">������ ��ü�� ���� ǥ��</param>
    /// <returns></returns>
    public Enemy Create(ENEMYTYPE type)
    {
        switch(type)
        {
            case ENEMYTYPE.Goblin:
                return new Goblin();
            case ENEMYTYPE.Slime:
                return new Slime();
            case ENEMYTYPE.Wolf:
                return new Wolf();
            default:
                // ���� ��Ȳ �߻�(������ ����� �ȵ� ���
                throw new System.Exception("���� ����");
        }
    }
}
