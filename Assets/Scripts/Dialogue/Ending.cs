using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public bool isEnding = false;
    public void HappyEnding()
    {
        //isEnding = true;
        //유로파 배경
        SystemManager.Instance.DialogueTrigger.ChangeBG(6);
        //해피 엔딩
        SystemManager.Instance.DialogueShow.StartDialogue("HappyEnding");
    }
}
