using UnityEngine;

public class CreateObject2 : MonoBehaviour
{
    public GameObject prefab;

    private GameObject square;

    void Start()
    {
        square = Instantiate(prefab);

        // 5�� �ڿ� �ı��մϴ�.
        Destroy(square, 5.0f);
        Debug.Log("�ı��Ǿ����ϴ�.");
    }

    void Update()
    {
        
    }
}
