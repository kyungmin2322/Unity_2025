using UnityEngine;

public enum Rainbow
{
    ������,
    ��Ȳ��,
    �����,
    �ʷϻ�,
    �Ķ���,
    ����,
    �����
}

[AddComponentMenu("KM/Sample01")]
public class Sample01 : MonoBehaviour
{
    public bool bIsJump;

    public string[] sBasket;

    public int iMoney;

    [Range(1, 99)]
    public int iFieldofView;

    public Rainbow rRainbow;
}
