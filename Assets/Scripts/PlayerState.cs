using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    [SerializeField]
    GameObject stateImg;

    [SerializeField] Text HPTxt;
    [SerializeField] Text BloodTxt;
    [SerializeField] Text HungerTxt;
    [SerializeField] Text MoneyTxt;

    [SerializeField]
    bool isShowing = false;

    Player player => SystemManager.Instance.Player;

    void Start()
    {
        stateImg.SetActive(isShowing);
    }

    public void OnClick()
    {
        isShowing = !isShowing;
        Showing(isShowing);
        HPText();
        BloodText();
        HungerText();
        MoneyText();
        
    }

    public void Showing(bool isShowing)
    {
        stateImg.SetActive(isShowing);
    }

    void HPText()
    {
        if (player.HP >= 10)
            HPTxt.text = "���̴����� ���� ���� �ǰ��ϴ�";
        else if (player.HP < 10 && player.HP >= 5)
            HPTxt.text = "���̴����� ���� �׷����� ������";
        else if (player.HP < 5 && player.HP >= 3)
            HPTxt.text = "���̴����� ���� ���� �� ����";
        else if (player.HP < 3)
            HPTxt.text = "���̴����� �ݹ��̶� ������ �� ����";
               

    }

    void BloodText()
    {
        if (player.Blood >= 4500)
            BloodTxt.text = "���̴����� ���� �ǰ� ����ϴ�";
        else if (player.Blood < 4500 && player.Blood >= 3000)
            BloodTxt.text = "���̴����� ���� �ǰ� �����ϴ�";
        else if (player.Blood < 3000 && player.Blood >= 1000)
            BloodTxt.text = "���̴����� ���� �ǰ� �����Ѵ�";
        else if (player.Blood < 1000)
            BloodTxt.text = "���̴����� �ǰ� ������ ��������";

    }

    void HungerText()
    {
        if (player.Hunger >= 8)
            HungerTxt.text = "���̴����� �谡 �θ���";
        else if (player.Hunger < 8 && player.Hunger >= 4)
            HungerTxt.text = "���̴����� �ణ �������";
        else if (player.Hunger < 4 && player.Hunger >= 2)
            HungerTxt.text = "���̴����� �谡 ������";
        else if (player.Hunger < 2)
            HungerTxt.text = "���̴����� �谡 ���ļ� ���� �� ����";
    }

     void MoneyText()
    {
        MoneyTxt.text = $"���̴����� {player.Money}ũ������ ������ �ִ�";
    }
}
