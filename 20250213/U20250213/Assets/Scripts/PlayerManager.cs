using System;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public SoundManager soundManager;
    public ItemManager item;

    void Start()
    {
        soundManager.OnPlay += PlaySound;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            soundManager.Play("등장 배경음");
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            DropItem();
        }
    }

    private void DropItem()
    {
        var item_Object = item.gameObject;
        Instantiate(item_Object, transform.position, Quaternion.identity);
    }

    public void PlaySound(string soundName)
    {
        Debug.Log(soundName + "플레이 중 입니다.");
    }
}
