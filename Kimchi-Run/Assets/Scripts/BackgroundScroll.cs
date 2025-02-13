using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("How fast should the texture scroll?")]
    public float scrollSpeed;

    [Header("References")]
    public MeshRenderer meshRenderer;

     void Start()
    {
        
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed
            * GameManager.Instance.CalculateGameSpeed() / 20 * Time.deltaTime, 0);   
    }
}
