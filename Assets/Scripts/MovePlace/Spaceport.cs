using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceport : MovePlace
{
    [SerializeField]
    GameObject buyBtn;

    [SerializeField] AudioSource spaceportSound;

    void Start()
    {
        buyBtn.SetActive(false);
    }

    public override void Move()
    {
        spaceportSound.Play();
        base.Move();
        SystemManager.Instance.Bloodshop.isDreaming = false;
        buyBtn.SetActive(true);
    }

    public override void GoOut()
    {
        base.GoOut();
        spaceportSound.Stop();
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
            SystemManager.Instance.Ending.EndingDialogue("HappyEnding");

        }
    }

}
