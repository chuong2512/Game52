using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkinSelector : MonoBehaviour
{
    private PlayerData playerData; //todo delete
    private GameDataManager gameData; //todo delete
    public TextMeshProUGUI diamonds;
    public int currentSkin;
    public SkinItem[] skinItems;

    void Start()
    {
        gameData = GameDataManager.Instance;
        playerData = gameData.playerData;
        
        diamonds.text = "" + playerData.intDiamond;
        currentSkin = playerData.currentSkin;
        skinItems[currentSkin].Choose();
        for (int i = 0; i < skinItems.Length; i++)
        {
            if (playerData.listSkins[i])
            {
                skinItems[i].Unlock();
            }
        }
    }
    
    public void ChooseSkin(int index)
    {
        if (currentSkin == index)
        {
            return;
        }
        else if (playerData.listSkins[index] == false)
        {
            if (!playerData.CheckCanUnlock())
            {
                return;
            }
            UnlockSkin(index);
        }
        
        skinItems[currentSkin].UnChoose();
        skinItems[index].Choose();
        currentSkin = index;
        playerData.currentSkin = currentSkin;
        //todo add Playerdata
    }

    public void UnlockSkin(int index)
    {
        if (!playerData.listSkins[index])
        {
            playerData.SubDiamond(Constant.priceUnlockSkin);
        }
        
        diamonds.text = playerData.intDiamond.ToString();
        skinItems[index].Unlock();
        playerData.listSkins[index] = true;
    }

    public void AddDiamonds(int value)
    {
        IAPManager.OnPurchaseSuccess = () =>
        {
            //todo add PlayerData
            playerData.AddDiamond(value);
            diamonds.text = playerData.intDiamond.ToString();
        };

        switch (value)
        {
            case 100:
                IAPManager.Instance.BuyProductID(Key.PACK1);
                break;
            case 200:
                IAPManager.Instance.BuyProductID(Key.PACK2);
                break;
            case 500:
                IAPManager.Instance.BuyProductID(Key.PACK3);
                break;
            case 1000:
                IAPManager.Instance.BuyProductID(Key.PACK4);
                break;
        }
    }

}
