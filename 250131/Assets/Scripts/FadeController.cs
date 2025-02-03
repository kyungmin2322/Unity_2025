using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
    public Image iImage;
    public GameObject gFadeButton;

    public void FadeSET()
    {
        gFadeButton.SetActive(false);
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float fFadeCount = 0.0f;
        while(fFadeCount < 1.0f)
        {
            fFadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            iImage.color = new Color(0, 0, 0, fFadeCount);
        }
        yield return null;
    }
}
