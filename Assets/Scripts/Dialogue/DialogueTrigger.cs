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
    //6.Uropa
    [SerializeField]
    Material[] backMat;
    [SerializeField]
    MeshRenderer background;
    [SerializeField]
    GameObject buttonCollection;

    void Start()
    {
        SystemManager.Instance.DialogueShow.StartDialogue("Start");
        ChangeBG(5);
    }

    public void OnClickNextStage()
    {
        //클릭한 버튼 오브젝트 가져오기
        string btnName = EventSystem.current.currentSelectedGameObject.name;

        //StartDialogue
        SystemManager.Instance.DialogueShow.StartDialogue(btnName);

        //어디로 갈지 정하는 인덱스
        int stageIndex = 0;
        switch (btnName)
        {
            case "House":
                stageIndex = 0;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                SystemManager.Instance.House.Move();
                break;

            case "BloodShop":
                stageIndex = 1;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                SystemManager.Instance.Bloodshop.Move();
                break;

            case "Spaceport":
                stageIndex = 2;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                SystemManager.Instance.Spaceport.Move();
                break;

            case "Park":
                stageIndex = 3;
                background.material = backMat[stageIndex];
                buttonCollection.SetActive(false);
                SystemManager.Instance.Park.Move();
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
        ChangeBG(5);
        buttonCollection.SetActive(true);
    }

    public void ChangeBG(int num)
    {
        background.material = backMat[num];
    }
}
