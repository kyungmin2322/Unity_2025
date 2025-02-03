using UnityEngine;

public class CreateObject2 : MonoBehaviour
{
    public GameObject prefab;

    private GameObject square;

    void Start()
    {
        square = Instantiate(prefab);

        // 5초 뒤에 파괴합니다.
        Destroy(square, 5.0f);
        Debug.Log("파괴되었습니다.");
    }

    void Update()
    {
        
    }
}
