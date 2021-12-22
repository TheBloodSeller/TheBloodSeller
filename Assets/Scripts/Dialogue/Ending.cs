using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    [SerializeField] AudioSource happyEndingSound;
    [SerializeField] AudioSource badEndingSource;
    [SerializeField] MainBtn mainbtn;
    public void EndingDialogue(string endingName)
    {
        mainbtn.StartCoroutine(mainbtn.FadeOut());
        Debug.Log(endingName);
        SystemManager.Instance.DialogueShow.isEnding = true;
        if (endingName == "HappyEnding")
        {
            happyEndingSound.Play();
            SystemManager.Instance.DialogueTrigger.ChangeBG(6);

        }
        else
        {
            badEndingSource.Play();
            SystemManager.Instance.DialogueTrigger.ChangeBG(5);
        }

        SystemManager.Instance.DialogueShow.StartDialogue(endingName);
    }
}
