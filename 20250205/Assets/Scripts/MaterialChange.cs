using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Material skyboxMaterial;

    void Start()
    {
        RenderSettings.skybox = skyboxMaterial;
    }

    void Update()
    {
        
    }
}
