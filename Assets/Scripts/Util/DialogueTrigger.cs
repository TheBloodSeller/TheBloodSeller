using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DialogueTrigger : MonoBehaviour
{
    //0:House
    //1.BloodShop
    //2.Spaceport
    //3.Park
    //4.Market
    //5.Space
    [SerializeField]
    Material[] backMat;
    [SerializeField]
    MeshRenderer background;
    [SerializeField]
    GameObject buttonCollection;

    void Start()
    {
        SystemManager.Instance.DialogueShow.StartDialogue("Start");
        background.material = backMat[5];
    }

    public void OnClickNextStage()
    {
        //Ŭ���� ��ư ������Ʈ ��������
        string btnName = EventSystem.current.currentSelectedGameObject.name;

        //StartDialogue
        SystemManager.Instance.DialogueShow.StartDialogue(btnName);

        //���� ���� ���ϴ� �ε���
        int stageIndex = 0;
        switch (btnName)
        {
            case "House":
                stageIndex = 0;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                
                break;

            case "BloodShop":
                stageIndex = 1;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                break;

            case "Spaceport":
                stageIndex = 2;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                break;

            case "Park":
                stageIndex = 3;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                break;

            case "Market":
                stageIndex = 4;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                SystemManager.Instance.Market.Move();
                break;

            default:
                break;
        }
        
    }

    public void MainScene()
    {
        background.material = backMat[5];
        buttonCollection.SetActive(true);
    }
}
