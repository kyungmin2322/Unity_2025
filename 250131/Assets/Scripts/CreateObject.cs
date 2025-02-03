using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        // ���� ��� Instantiate()

        // ��� �س��� ������ �״�θ� �����մϴ�.
        Instantiate(prefab);

        // Vector3 : ����� ũ�⸦ �����ϴ� ����
        // ĳ������ position, ������Ʈ�� �̵��ӵ�, ������Ʈ ����
        // �Ÿ� ���� ����� �� ����ϴ� Ŭ����
        // 2D -> Vector2(x, y)
        // 3D -> Vector3(x, y, z)

        // Quaternion : ���� ������Ʈ�� 3���� ������ ����
        // �� ���⿡�� �ٸ� ���������� ������� ȸ�� ��
        // ����� ȸ���� �� ǥ���� �� �ִ� Ŭ����
        // 180�� ���� ū ���� ���� ǥ���� �� �� ����.

        // ��� �س��� �����հ� ��ġ�� ȸ�� ������ �� �����ϰ� ������ �����մϴ�.
        // Quaternion.identity => ȸ�� �� 0
        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
