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
            HPTxt.text = "새미누리는 몸이 아주 건강하다";
        else if (player.HP < 10 && player.HP >= 5)
            HPTxt.text = "새미누리는 몸이 그럭저럭 괜찮다";
        else if (player.HP < 5 && player.HP >= 3)
            HPTxt.text = "새미누리는 몸이 조금 안 좋다";
        else if (player.HP < 3)
            HPTxt.text = "새미누리는 금방이라도 쓰러질 것 같다";
               

    }

    void BloodText()
    {
        if (player.Blood >= 4500)
            BloodTxt.text = "새미누리는 몸에 피가 충분하다";
        else if (player.Blood < 4500 && player.Blood >= 3000)
            BloodTxt.text = "새미누리는 몸에 피가 적당하다";
        else if (player.Blood < 3000 && player.Blood >= 1000)
            BloodTxt.text = "새미누리는 몸에 피가 부족한다";
        else if (player.Blood < 1000)
            BloodTxt.text = "새미누리는 피가 부족해 어지럽다";

    }

    void HungerText()
    {
        if (player.Hunger >= 8)
            HungerTxt.text = "새미누리는 배가 부르다";
        else if (player.Hunger < 8 && player.Hunger >= 4)
            HungerTxt.text = "새미누리는 약간 허기진다";
        else if (player.Hunger < 4 && player.Hunger >= 2)
            HungerTxt.text = "새미누리는 배가 고프다";
        else if (player.Hunger < 2)
            HungerTxt.text = "새미누리는 배가 고파서 죽을 꺼 같다";
    }

     void MoneyText()
    {
        MoneyTxt.text = $"새미누리는 {player.Money}크래딧을 가지고 있다";
    }
}
