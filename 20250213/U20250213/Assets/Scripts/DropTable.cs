using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


// CreatAssetMenu ����
// ()�ȿ� fileName, menuName, order�� ������ �� �ִ�.
// fileName : �����Ǵ� ������ �̸�
// menuName : Create�� ���� ��������� �޴��� �̸��� �����Ѵ�.
//          /�� ���� ���, ��ΰ� �߰��ȴ�.
// order : �޴� �߿��� �� ��° ��ġ�� ������ �� ǥ���� �� �����ϴ� ��, ���� Ŭ���� �������� ǥ��ȴ�.
[CreateAssetMenu(fileName = "DropTable", menuName = "DropTable/drop table", order = 0)]
public class DropTable : ScriptableObject
{
    public List<GameObject> itemList;
}
