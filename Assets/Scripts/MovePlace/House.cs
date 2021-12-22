using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MovePlace
{

    public bool isHouse;

    [SerializeField]
    AudioSource houseSound;
    [SerializeField] AudioSource dreamSound;

    public override void Move()
    {
        isHouse = true;
        houseSound.Play();
        base.Move();
        Sleep();
    }

    public override void GoOut()
    {
        houseSound.Stop();
        dreamSound.Stop();
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
        houseSound.Stop();
        player.Dream++;
        SystemManager.Instance.DialogueTrigger.ChangeBG(5);
        dreamSound.Play();
        if (player.Dream > 20)
        {
            SystemManager.Instance.DialogueShow.StartDialogue("DreamEnd");
        }
        SystemManager.Instance.DialogueShow.StartDialogue("Dream" + SystemManager.Instance.Player.Dream);
        isHouse = false;
    }
}
