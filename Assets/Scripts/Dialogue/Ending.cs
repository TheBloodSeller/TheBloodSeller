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
        //������ ���
        SystemManager.Instance.DialogueTrigger.ChangeBG(6);
        //���� ����
        SystemManager.Instance.DialogueShow.StartDialogue("HappyEnding");
    }
}
