using UnityEngine;

public class Background : MonoBehaviour
{
    public Material backgroundMaterial;
    public float scrollSpeed = 0.2f;

    void Update()
    {
        backgroundMaterial.mainTextureOffset += 
            Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
