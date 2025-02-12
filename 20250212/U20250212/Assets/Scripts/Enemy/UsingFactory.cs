using UnityEngine;

public class UsingFactory : MonoBehaviour
{
    // �� ���丮 ���
    EnemyFactory enemyFactory = new EnemyFactory();

    void Start()
    {
        // ��� �׽�Ʈ
        Enemy enemy1 = enemyFactory.Create(EnemyFactory.ENEMYTYPE.Goblin);
        enemy1.Action();
        Enemy enemy2 = enemyFactory.Create(EnemyFactory.ENEMYTYPE.Slime);
        enemy2.Action();
        Enemy enemy3 = enemyFactory.Create(EnemyFactory.ENEMYTYPE.Wolf);
        enemy3.Action();
    }

    void Update()
    {
        
    }
}
