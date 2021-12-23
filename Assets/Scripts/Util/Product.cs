using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Product : MonoBehaviour
{
    Player Player => SystemManager.Instance.Player;
    [SerializeField] TMP_Text priceText;

    [SerializeField] string productName;
    [SerializeField] int price;

    [SerializeField] float healAmount;
    [SerializeField] float feedAmount;

    [SerializeField] AudioSource buySound;

    void Start()
    {
        priceText.text = price.ToString();
    }



    public void OnClick()
    {
        if(TryPurchase(price, SystemManager.Instance.Player.Money))
        {
            Purchase(price);
        }
        else
        {
            //구매 실패 시 처리
            SystemManager.Instance.DialogueShow.StartDialogue("NoMoney");
        }
    }

    /// <summary>
    /// 아이템 구매를 시도합니다.
    /// </summary>
    /// <param name="price">아이템의 가격</param>
    /// <param name="money">플레이어가 소지하고 있는 돈</param>
    /// <returns>구매 성공 여부</returns>
    bool TryPurchase(int price, int money)
    {
        return price <= money;
    }

    void Purchase(int price)
    {
        Player.Money -= price;
        buySound.Play();
        UseProduct();
    }


    void UseProduct()
    {
        //플레이어 회복 혹은 허기 회복.
        Player.Hunger += (int)feedAmount;
        Player.HP += (int)healAmount;
        SystemManager.Instance.DialogueShow.StartDialogue(this.name);


    }

    void OnValidate()
    {
        priceText.text = price.ToString();
    }
}
