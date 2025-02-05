using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    // 1.   이 클래스는 오브젝트를 생성하는 기능을 가지고 있습니다.
    // 2.   마우스 버튼을 눌렀을 때, 카메라의 스크린 지점을 통해
    //      물체의 방향을 설정합니다.
    // 3.   물체를 방향에 맞춰 발사하는 기능을 호출해옵니다.

    public GameObject prefab; // 오브젝트 프리팹 등록
    public float power = 1000f;

    void Update()
    {
        // ~down : 클릭 시 1번
        // ~up : 버튼을 놓았을 때 1번
        // : 클릭하고 있는 동안 지속

        // 마우스 0번 버튼을 눌렀을 때
        // 마우스 버튼
        // 0 : 왼쪽
        // 1 : 오른쪽
        // 2 : 휠
        if(Input.GetMouseButtonDown(0))
        {
            var thrown = Instantiate(prefab);
            // + as GameObject : Instantiate와 같이 사용하면
            // 게임 오브젝트로써 생성하라는 의미.

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // 레이(Ray)
            // 가상의 레이저 선으로, 발사되는 시작 지점과 방향
            // 일반적인 Ray는 Vector3의 값을 가지고, Ray2D의 경우는 Vector2의 값을 가지게 된다.

            // 일반적인 레이 만드는 방법
            Vector3 origin = new Vector3(0, 0, 0);
            Vector3 vect_dir = Vector3.forward;
            Ray newRay = new Ray(origin, vect_dir);

            // 레이는 데이터만 가지고 있는 구조체이므로, 기능적으로는 할 수 있는것이 없으며
            // Ray를 이용한 방향 계산이나 RayCast를 이용한 오브젝트 충돌 기능으로 활용한다.

            Vector3 direction = ray.direction; // 방향 설정

            thrown.GetComponent<ObjectShooter>().Shoot(direction.normalized * power);

        }
    }
}
