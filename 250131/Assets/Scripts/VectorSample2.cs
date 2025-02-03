using UnityEngine;

public class VectorSample2 : MonoBehaviour
{
    // VectorSample�� ���� �����ϸ� ����.
    
    void Start()
    {
        // 1. Normalization(����ȭ)
        // ������ ũ�⸦ 1�� �����Ѵ�.
        // ���� ������ ������, ũ�⸸ 1�� ����
        // ũ�⸦ 1�� �����ϰ� ������ ���⸸ ����ϸ� ���� ������ ó���ϱ� ����.
        // ���� : �Է����� ĳ������ 3D �̵� ����� �̵��� �밢�� ���
        //       �Ϲ����� ���� ���⺸�� �̵��ӵ��� �� ���� ��Ȳ�� �߻��� �� ����.

        Vector3 a = new Vector3(1, 2, 0);
        Vector3 nomal_a = a.normalized;

        // 2. �� ���� ������ �Ÿ� ���
        Vector3 positionA = new Vector3(1, 2, 3);
        Vector3 positionB = new Vector3(4, 5, 6);

        float distance = Vector3.Distance(positionA, positionB);
        // �� ������ ������ ũ�Ⱑ ���ȴ�.

        // 3. ���� ����(Linear Interpolation) -> Lerp
        // �� ���� ���� �����Ǿ��� ��, �� ���̿� ��ġ�� ���� �����ϱ� ����
        // �����Ÿ��� ���� ���������� ����ϴ� ���
        Vector3 Result = Vector3.Lerp(positionA, positionB, 0.5f);

        // ���� : A������ (2, 1)�̰�, B������ (6, 4)�� ��,
        //      �� ������ ���� C�� X ��ǥ�� �־����ٸ�,
        //      Y ��ǥ���� �� �� �ִ�.
    }
}
