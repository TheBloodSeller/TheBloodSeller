using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    public void HappyEnding()
    {
        SystemManager.Instance.DialogueShow.isEnding = true;
        SystemManager.Instance.DialogueTrigger.ChangeBG(6);
        SystemManager.Instance.DialogueShow.StartDialogue("HappyEnding");
    }

    public void DeadEnding_HP()
    {
       
        
    }

    public void EndingDialogue(string endingName)
    {
        Debug.Log(endingName);
        SystemManager.Instance.DialogueShow.isEnding = true;
        if (endingName == "HappyEnding")
            SystemManager.Instance.DialogueTrigger.ChangeBG(6);
        else
            SystemManager.Instance.DialogueTrigger.ChangeBG(5);
        
        SystemManager.Instance.DialogueShow.StartDialogue(endingName);
    }
}
