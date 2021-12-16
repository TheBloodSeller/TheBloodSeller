using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ChangeMat : MonoBehaviour
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
        MainScene();
        
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
                break;

            case "BloodShop":
                stageIndex = 1;
                break;

            case "Spaceport":
                stageIndex = 2;
                break;

            case "Park":
                stageIndex = 3;
                break;

            case "Market":
                stageIndex = 4;
                break;

            default:
                break;
        }
        background.material = backMat[stageIndex];
        buttonCollection.SetActive(false);
        
    }

    public void MainScene()
    {
        background.material = backMat[5];
    }
}
