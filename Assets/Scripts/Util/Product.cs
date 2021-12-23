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
            //���� ���� �� ó��
            SystemManager.Instance.DialogueShow.StartDialogue("NoMoney");
        }
    }

    /// <summary>
    /// ������ ���Ÿ� �õ��մϴ�.
    /// </summary>
    /// <param name="price">�������� ����</param>
    /// <param name="money">�÷��̾ �����ϰ� �ִ� ��</param>
    /// <returns>���� ���� ����</returns>
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
        //�÷��̾� ȸ�� Ȥ�� ��� ȸ��.
        Player.Hunger += (int)feedAmount;
        Player.HP += (int)healAmount;
        SystemManager.Instance.DialogueShow.StartDialogue(this.name);


    }

    void OnValidate()
    {
        priceText.text = price.ToString();
    }
}
