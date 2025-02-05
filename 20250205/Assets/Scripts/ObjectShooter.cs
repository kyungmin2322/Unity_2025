using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ObjectShooter : MonoBehaviour
{
    // �߻� ����� �������ִ� Ŭ����
    // �浹 �� ������Ʈ�� ���������ִ� ���ҵ� �����մϴ�.

    GameObject objectGenerator;
    // ObjectGenerator obj;

    void Start()
    {
        objectGenerator = GameObject.Find("ObjectGenerator");
        // == ������Ʈ Ž�� ��� ==
        // ������ �ش� �̸��� ���� ������Ʈ�� ã�� �� ���� ������ GameObject.Find() ���
        // objectGenerator = GameObject.FindWithTag("Generator"); // Generator �±׸� ���� ������Ʈ�� Ž��
        // obj = GameObject.FindObjectOfType<ObjectGenerator>(); // <> �ȿ� �־��� Ÿ�Կ� �´� ������Ʈ�� Ž��

        // ���� ���� �� Find()
        // ������, �˻� ������ �ʹ� �������� ���ʿ��ϰ� ���� ���ϰ� �߻��� �� ����.
        // ����, �� ������ Tag�� Type ������ �˻� ������ �����ؼ� ã�� ����� ���.

        // ���� �ش� ���� ������ null

    }

    /// <summary>
    /// ��ü�� �߻��ϴ� ����� ���� �Լ�(�޼ҵ�)
    /// </summary>
    /// <param name="direction">��ü�� �߻� ����</param>
    public void Shoot(Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(direction);
        Debug.Log("�������ϴ�!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponentInChildren<ParticleSystem>().Play();

        if(collision.gameObject.tag == "terrain")
        {
            Destroy(gameObject, 1.0f);
        }
        else // ������ ��� 
        {
            objectGenerator.GetComponent<ObjectGenerator>().ScorePlus(10);
            GetComponent<ObjectGenerator>().TargetDown();
        }
    }
}
