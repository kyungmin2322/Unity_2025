using UnityEngine;

[AddComponentMenu("KM/Sample01")]
public class Misson1 : MonoBehaviour
{
    [Header("점프 가능 여부")]
    public bool bIsJump = true;

    [Header("과일바구니")]
    public string sFruitBox;

    [Header("돈")]
    public int iMoney;

    [Header("필드 뷰")]
    [Range(1, 99)]
    public int iField;

    [Header("무지개")]
    public string sRainbow;
}
