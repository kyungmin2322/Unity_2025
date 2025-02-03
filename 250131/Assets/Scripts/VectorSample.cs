using UnityEngine;

public class VectorSample : MonoBehaviour
{
    // �⺻ ���� (x, y, z) ������ ���� �ۼ���.
    Vector3 vec = new Vector3();

    float x = 10.0f, y = 20.0f, z = 30.0f;

    Vector3 custom_vec = new Vector3();

    // ����Ƽ �⺻ ����(���� ��)
    // Vector3 a = Vector3.up;
    // up : (0, 1, 0)
    // down : (0, -1, 0)
    // left : (-1, 0, 0)
    // right : (1, 0, 0)
    // forward : (0, 0, 1)

    // ���� �⺻ ����(����, ����, ������, ����)
    Vector3 a = new Vector3(1, 2, 0);
    Vector3 b = new Vector3(3, 4, 0);

    Vector3 some = Vector3.zero;
    float point = 5.0f;

    // ���� ����

    Vector3 Asite = new Vector3(10, 0, 0);
    Vector3 Bsite = new Vector3(5, 0, 0);

    float attack_position = 5.0f;

    void Start()
    {
        // ���� : �ܰ������� �ϳ��� ���ʴ�� ó���Ѵ�.
        // ������ ����Ǿ ����� ����.
        // Ư�� �����ǿ��� ������ ������ ��� ó��
        // ��ġ �̵�, ��Ż
        Vector3 c = a + b;

        // var : C#���� ���� �������� �����͸� �ڵ����� �����ϴ� Ű����
        // ���� �ڵ� �������� ���� ���� �������� ������ var �� Vector3
        var trap_air = some + new Vector3(0, point);

        // ����
        // �� ������Ʈ���� �ٸ� ������Ʈ ������ �Ÿ��� ������ ���ϴ� ��Ȳ�� ���
        // ��� ������ �߿��ϴ�
        Vector3 d = a - b;

        // �� �Ÿ��� ���� �� ������ �Ÿ��� ���ų� �����ٸ�
        // ���� �ڵ带 ¥�� ����.
        Vector3 distance = Asite - Bsite;

        // ����
        // ������ �� ���п� ��Į�� ���� ���Ѵ�.
        // ���� * ��Į�� => ������ ������ ������ ����Ű�� ����
        //���� ��ü���� ������ ���ְ� ������ ũ�⸦ �����ϴ� ��쿡 ����Ѵ�.
        Vector3 e = a * 2;

        // ������
        Vector3 Position = Vector3.one;
        Position = Position * 4; // 4, 4, 4

        // ���� & ����
        // ���� : 2D, 3D �� ����
        // �� ������ ������ ���ϰ� �� ����� ��� ���ϴ� ���� ���
        Vector3 k = new Vector3(1, 2, 3);
        Vector3 l = new Vector3(4, 5, 6);

        // k * l = (kx * lx) + (ky * ly) + (kz * lz)
        // �� ����� �� ��ǥ�� �󸶳� ���������� �Ǵ��Ѵ�.
        // �� ���� ������ ����
        float dot = Vector3.Dot(k, l);

        // ���� : 3D���� ���(3D �׷���)
        // ���� ���� ��� �ÿ� ���ȴ�.
        // ���� : ����̳� ������ ���Ͽ� ������ ���� �ǹ���.
        Vector3 cross = Vector3.Cross(k, l);
        // k * l = (ky * lz - kz * ly, kz * lx - kx * lz, kx * ky = ky * kx)


        // ������ ũ��(������ ����)
        Vector3 m = new Vector3(1, 2, 3);
        float mag = m.magnitude;
        // ������ �� ������ ���� ���� ������
    }

    void Update()
    {
        
    }
}
