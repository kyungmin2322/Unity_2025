// �ؽ�Ʈ�� ī��Ʈ�� ����ϴ� ����� �����Ѵ�.
// ī��Ʈ�� ��� 1�� �����ϴ� ���·� ó���Ѵ�.

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextCount : MonoBehaviour
{
    private int iCount;
    public Text tCountText;

    void Start()
    {
        // �ڷ��� ��� ���

        // StartCoroutine("�Լ��� �̸�(IEnumerator ������ �Լ�)");
        // 1. ���ڿ��� ���� �Լ��� ã�Ƽ� �����ϴ� ���
        // ��Ÿ�� �߻��ص� ������ �߻����� ����.
        // ������ ����� ������� ����.
        // StopCoroutine()�� ���� �ܺο��� �����ϴ� ���� �����ϴ�.

        // �ߴ� ����, ȿ�� ����
        /*StartCoroutine("CountPlus");
        StopCoroutine("CountPlus");

        // StartCoroutine(�Լ��� �̸�());
        // 2. �ش� �Լ��� ȣ���� ���� ����� ��ȯ�޴� ����
        // ��Ÿ �߻� �� ���� üũ ����
        // �� ������δ� StopCoroutine()�� ���� �ܺο����� �߱� ����� ����� �� ����.

        // �ߴ� �Ұ���, ȿ�� ����
        StartCoroutine(CountPlus());*/


        StartCoroutine("CountPlus");
    }

    IEnumerator CountPlus()
    {
        while(true)
        {
            iCount++;
            tCountText.text = iCount.ToString("N0");
            // C#�� ToString()�� ���� ���� ���·� ������ ����
            // N0�� ���� 3�ڸ� �������� ,�� ǥ���ϴ� format�̴�.
            // 1000 -> 1,000

            yield return new WaitForSeconds(0.1f);
            // ���� �������� �Ѿ��.
        }

        /*Debug.Log("�ƾ� ����ũ �׽�Ʈ");
        yield return new WaitForSeconds(1);

        // yield�� �Ͻ������� CPU�� ������ �ٸ� �Լ��� �����ϴ� Ű�����̴�.

        Debug.Log("�丸 �԰� �ð�");
        yield return new WaitForSeconds(5);
        Debug.Log("�ٽ� ���� �غ���?");*/
    }
}
