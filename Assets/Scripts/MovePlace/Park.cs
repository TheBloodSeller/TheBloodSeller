using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Park : MovePlace
{
    [SerializeField]
    GameObject CardBar;
    [SerializeField]
    GameObject CardBtn;

    [SerializeField]
    TMP_Text[] numText;

    [SerializeField] AudioSource parkSound;
    [SerializeField] AudioSource cardSound;

    int[] nums;

    void Awake()
    {
        nums = new int[3] { 0,0,0};

    }

    void Start()
    {
        CardBar.SetActive(false);
        CardBtn.SetActive(false);
    }


    public override void Move()
    {
        base.Move();
        parkSound.Play();
        SystemManager.Instance.Bloodshop.isDreaming = false;
        CardBtn.SetActive(true);
        
    }

    public override void GoOut()
    {
        base.GoOut();
        parkSound.Stop();
        CardBtn.SetActive(false);
        CardBar.SetActive(false);
    }

    public void OnClick()
    {
        if (player.Money < 100)
        {
            SystemManager.Instance.DialogueShow.StartDialogue("NoMoney");
            return;
        }

        player.Money -= 100;

        CardBar.SetActive(true);
        for (int i = 0; i < numText.Length; i++)
        {
            cardSound.Play();
            nums[i] = Random.Range(1, 10);
            numText[i].text = nums[i].ToString();
        }

        //��� ���
        GameResults();


        CardBtn.SetActive(false);   
    }

    void GameResults()
    {
        SystemManager.Instance.DialogueShow.SentanceCount = 0;

        //if���� �̿��ؼ� ����� ���
        if (nums[0] == nums[1] && nums[0] == nums[2])
        {
            SystemManager.Instance.DialogueShow.StartDialogue("Winning");
            player.Money += 9744;
        }
        else{
            SystemManager.Instance.DialogueShow.StartDialogue("Loseing");
        }

    }
}
