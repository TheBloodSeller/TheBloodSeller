using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceport : MovePlace
{
    [SerializeField]
    GameObject buyBtn;

    public bool isHappyEnding = false;

    void Start()
    {
        buyBtn.SetActive(false);
    }

    public override void Move()
    {
        base.Move();
        SystemManager.Instance.DialogueShow.StartDialogue("Spaceport");
        SystemManager.Instance.Bloodshop.isdreaming = false;
        buyBtn.SetActive(true);
    }

    public override void GoOut()
    {
        base.GoOut();
        buyBtn.SetActive(false);
    }

    public void OnClick()
    {
        if (player.Money < 35000000)
        {
            SystemManager.Instance.DialogueShow.StartDialogue("NoMoney");
            return;
        }
        else
        {
            buyBtn.SetActive(false);
            //해피엔딩
            SystemManager.Instance.Ending.HappyEnding();
        }
    }

}
