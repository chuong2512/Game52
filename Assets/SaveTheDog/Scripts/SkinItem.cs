using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinItem : MonoBehaviour
{
    public GameObject lockObj;
    public Image iconImage;
    public Sprite choosePattern;
    public Sprite unchoosePattern;

    public void Init(Sprite sprite,bool isLock)
    {
        
    }

    public void Choose()
    {
        GetComponent<Image>().sprite = choosePattern;
    }

    public void UnChoose()
    {
        GetComponent<Image>().sprite = unchoosePattern;
    }

    public void Unlock()
    {
        lockObj.SetActive(false);
    }
}
