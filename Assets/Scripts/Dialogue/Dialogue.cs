using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DialogueText
{
    public string name;
    [TextArea]  //여러 문장을 쓸 수 있음
    public string text;
    public Sprite cg;
}

public class Dialogue : MonoBehaviour
{
    public int rank;    //대화의 흐름을 알려준다

    [SerializeField] private SpriteRenderer standingImg;
    [SerializeField] private GameObject dialogueImg;
    [SerializeField] private Text dialogueNameTxt;
    [SerializeField] private Text dialogueTxt;

    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private DialogueText[] dialogues;

    public void showDialogue()
    {
        OnOff(true);
        count = 0;

        NextDialogue();
    }

   
    void Start()
    {
        showDialogue();
    }

    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogues.Length)
                    NextDialogue();
                else
                    OnOff(false);
            }
        }
    }


    private void NextDialogue()
    {
        dialogueNameTxt.text = dialogues[count].name;
        dialogueTxt.text = dialogues[count].text;
        standingImg.sprite = dialogues[count].cg;
        count++;
    }

    private void OnOff(bool _flag)
    {
        dialogueImg.SetActive(_flag);
        standingImg.gameObject.SetActive(_flag);
        dialogueTxt.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

}
