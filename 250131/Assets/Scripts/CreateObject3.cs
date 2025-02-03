using UnityEngine;

public class CreateObject3 : MonoBehaviour
{
    // ����ȭ
    // Ư�� �����ͳ� ������Ʈ�� ��ǻ�� ȯ�濡 �����ϰ�
    // �籸���� �� �ִ� ����(����)�� ��ȯ�ϴ� ����
    // ����Ƽ������ �����ϰ� private ������ �����͸�
    // �ν����Ϳ��� ���� �� �ְ� �������ش� ��� �����ϸ� ����.
    [SerializeField] private GameObject prefab;
    private int dummy;

    [SerializeField] GameObject sample;

    void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/Table_Body");
    }

    void Update()
    {
        // �Է� ���� Ű�� �����̽��� ���
        // ~ Down : Ű �� �� �Է�
        // ~ Up : �Է� �� ���� ���
        // ~ : ������ �ִ� ����
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Resources.Load<T>("������ġ/���¸�");
            // T�� �������� ���¸� �����ִ� ��ġ

            // Sprite sprite = Resources.Load<Sprite>("Sprites/sprite01");

            sample = Instantiate(prefab);
            sample.AddComponent<VectorSample>();
            // gameObject.AddComponent<T>
            // ������Ʈ�� ������Ʈ ����� �߰��ϴ� ���.
            // GetComponent<T>
            // ������Ʈ�� ������ �ִ� ������Ʈ�� ����� ������ ���
            // ��ũ��Ʈ���� �ش� ������Ʈ�� ����� �����ͼ� ����ϰ� ���� ��� ���.
        }
    }
}
