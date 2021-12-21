using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceport : MovePlace
{
    [SerializeField]
    GameObject buyBtn;

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
            //유로파 배경
            SystemManager.Instance.DialogueTrigger.ChangeBG(6);
            //해피 엔딩
            SystemManager.Instance.DialogueShow.StartDialogue("HappyEnding");
        }
    }

}
