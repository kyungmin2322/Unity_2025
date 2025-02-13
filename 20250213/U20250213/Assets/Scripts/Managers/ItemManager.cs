using UnityEngine;

[CreateAssetMenu]
public class ItemManager : ScriptableObject
{
    // 아이템 데이터가 가지고 있는 게임 오브젝트
    public GameObject gameObject;

    public int id;
    public int price;
    public string description;
}
