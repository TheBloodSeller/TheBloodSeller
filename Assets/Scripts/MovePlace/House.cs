using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MovePlace
{

    public bool isHouse;

    public override void Move()
    {
        isHouse = true;
        base.Move();
        Sleep();
    }

    public override void GoOut()
    {
        isHouse = false;
        SystemManager.Instance.Bloodshop.isDreaming = false;
        base.GoOut();
    }

    //잠을 자고 체력 회복
    void Sleep()
    {
        if (player.Hunger >= 5)
            player.HP += 3;
        else
            player.HP += 1;

        player.Blood += 17;
        player.Hunger -= 2;
    }

    //꿈을 꾼다
    public void DreamCheck()
    {
        player.Dream++;
        SystemManager.Instance.DialogueTrigger.ChangeBG(5);
        SystemManager.Instance.DialogueShow.StartDialogue("Dream" + SystemManager.Instance.Player.Dream);
        isHouse = false;
    }
}
