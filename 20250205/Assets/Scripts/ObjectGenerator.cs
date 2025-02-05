using TMPro;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    // 1.   �� Ŭ������ ������Ʈ�� �����ϴ� ����� ������ �ֽ��ϴ�.
    // 2.   ���콺 ��ư�� ������ ��, ī�޶��� ��ũ�� ������ ����
    //      ��ü�� ������ �����մϴ�.
    // 3.   ��ü�� ���⿡ ���� �߻��ϴ� ����� ȣ���ؿɴϴ�.

    public GameObject prefab; // ������Ʈ ������ ���
    public GameObject target; // Ÿ�� ������ ���
    GameObject scoreText; // ���� ǥ��ǥ
    public float power = 1000f; // ��ô ���ݷ�
    public int score = 0; // ����
    float accTime = 0f;
    bool isFirst = true, isSecond = true;

    void Start()
    {
        scoreText = GameObject.Find("score"); // ���� ������ score�� ã�Ƽ� ���
        SetScoreText(); // ���� 1ȸ
    }

    /// <summary>
    /// ���� ȹ��
    /// </summary>
    /// <param name="value">��ġ</param>
    public void ScorePlus(int value)
    {
        score += value;
        SetScoreText();
    }

    /// <summary>
    /// �� ������ ���� ���
    /// </summary>
    void SetScoreText()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = $"���� : {score}";
    }

    public void TargetDown()
    {
        accTime += Time.deltaTime;

        if(isFirst)
        {
            target.transform.eulerAngles = new Vector3(90f, 0f, 0f);
            isFirst = false;
        }
        else if(isSecond && accTime >= 4f)
        {
            target.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            isSecond = false;
        }
        power += 100f;
    }

    void Update()
    {
        // ~down : Ŭ�� �� 1��
        // ~up : ��ư�� ������ �� 1��
        // : Ŭ���ϰ� �ִ� ���� ����

        // ���콺 0�� ��ư�� ������ ��
        // ���콺 ��ư
        // 0 : ����
        // 1 : ������
        // 2 : ��
        if(Input.GetMouseButtonDown(0))
        {
            var thrown = Instantiate(prefab);
            // + as GameObject : Instantiate�� ���� ����ϸ�
            // ���� ������Ʈ�ν� �����϶�� �ǹ�.

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // ����(Ray)
            // ������ ������ ������, �߻�Ǵ� ���� ������ ����
            // �Ϲ����� Ray�� Vector3�� ���� ������, Ray2D�� ���� Vector2�� ���� ������ �ȴ�.

            // �Ϲ����� ���� ����� ���
            Vector3 origin = new Vector3(0, 0, 0);
            Vector3 vect_dir = Vector3.forward;
            Ray newRay = new Ray(origin, vect_dir);

            // ���̴� �����͸� ������ �ִ� ����ü�̹Ƿ�, ��������δ� �� �� �ִ°��� ������
            // Ray�� �̿��� ���� ����̳� RayCast�� �̿��� ������Ʈ �浹 ������� Ȱ���Ѵ�.

            Vector3 direction = ray.direction; // ���� ����

            thrown.GetComponent<ObjectShooter>().Shoot(direction.normalized * power);

        }
    }
}
