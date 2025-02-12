// ����Ƽ���� �������ִ� Event, IPointer

// IPointer Interface
// Unity�� EventSystem���� �⺻������ �����Ǵ� �������̽�.
// ����ϱ� ���ؼ��� ������ ���� ������ �ʿ��Ѵ�.

// Ŭ��, ��ġ, �巡�� ���� �̺�Ʈ�� ������ �� ����Ѵ�.

// 1. UI ������Ʈ���� Graphic Raycaster ������Ʈ�� �߰��Ǿ� �־�� �Ѵ�.
//    �߰������� Raycast Target�� üũ�� �� ���¿��� �Ѵ�.

// 2. Scene���� Event System ������Ʈ�� �����ؾ� �Ѵ�.

// 3. ������Ʈ�� ���� �۾� �ÿ��� Collider ������Ʈ�� �߰��Ǿ� �־�� �Ѵ�.

// 4. Main Camera�� Physics Raycaster ������Ʈ�� �߰��Ǿ� �־�� �Ѵ�.


using UnityEngine;
using UnityEngine.EventSystems;

public class UInterSample : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Ŭ���� �����߽��ϴ�.");
    }

    // ��� ���
    // 1. �� ����� ����� ������Ʈ�� �����Ѵ�.
    // 2. ���� Event System ������Ʈ�� ��ġ�Ѵ�.
    //    ���࿡ ���� ĵ���� ������ �����ߴٸ�, �ڵ����� ��ġ�� �Ǹ�
    //    �ƴ� ����� ���� ���� �����Ѵ�.
    // 3. ������Ʈ�� �ݶ��̴��� �����Ѵ�.
    // 4. ī�޶� Physics Raycaster ������Ʈ�� �����Ѵ�.

    // IPointerClickHandler
    // �ش� I�� �߰��ϸ�, ���콺�� Ŭ�� �Ǵ� ��ġ�� �� �� �� ȣ��Ǵ� �̺�Ʈ
    // ������ ���� ��� ȣ�� �ȴ�.

    // IPointerDownHandler
    // ������ ������ ȣ��Ǵ� ���콺 Ŭ��/��ġ �̺�Ʈ

    // IPointerUpHandler
    // �� ��Ȳ�� ȣ��Ǵ� ���콺 Ŭ��/��ġ �̺�Ʈ

    // IBeginDragHandler
    // �巡�� ���� �� ȣ��Ǵ� �̺�Ʈ

    // IEndDragHandler
    // �巡�� ���� �� ȣ��Ǵ� �̺�Ʈ

    // IDragHandler
    // �巡�� ���� �� ȣ��Ǵ� �̺�Ʈ
}
