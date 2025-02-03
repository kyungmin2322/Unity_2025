using UnityEngine;

public enum Rainbow
{
    빨간색,
    주황색,
    노란색,
    초록색,
    파란색,
    남색,
    보라색
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
