using UnityEngine;

[AddComponentMenu("KM/Sample01")]
public class Misson1 : MonoBehaviour
{
    [Header("���� ���� ����")]
    public bool bIsJump = true;

    [Header("���Ϲٱ���")]
    public string sFruitBox;

    [Header("��")]
    public int iMoney;

    [Header("�ʵ� ��")]
    [Range(1, 99)]
    public int iField;

    [Header("������")]
    public string sRainbow;
}
