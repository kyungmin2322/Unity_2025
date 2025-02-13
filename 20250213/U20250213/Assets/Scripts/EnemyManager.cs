using System;
using UnityEngine;

// using System을 사용하면서 유니티의 랜덤을 사용하고 싶은 경우
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    // 몬스터의 드랍 테이블
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
        // Random.Range(최소, 최대)는 유니티에서 제공해주는 랜덤 문법
        // 최소 값 부터 최대 -1 까지 범위의 값 중 하나를 랜덤으로 선택한다.

        Instantiate(dropItemPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
