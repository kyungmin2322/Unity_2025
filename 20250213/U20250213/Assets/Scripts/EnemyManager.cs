using System;
using UnityEngine;

// using System�� ����ϸ鼭 ����Ƽ�� ������ ����ϰ� ���� ���
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    // ������ ��� ���̺�
    public DropTable DropTable;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Dead();
        }
    }

    private void Dead()
    {
        GameObject dropItemPrefab = DropTable.itemList[Random.Range(0, DropTable.itemList.Count)];
        // Random.Range(�ּ�, �ִ�)�� ����Ƽ���� �������ִ� ���� ����
        // �ּ� �� ���� �ִ� -1 ���� ������ �� �� �ϳ��� �������� �����Ѵ�.

        Instantiate(dropItemPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
