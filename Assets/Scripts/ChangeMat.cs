using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ChangeMat : MonoBehaviour
{
    //0:Space
    //1.House
    [SerializeField]
    Material[] backMat;
    [SerializeField]
    MeshRenderer background;
    [SerializeField]
    GameObject buttonCollection;

    void Start()
    {
        buttonCollection.SetActive(false);
    }

    public void ShowBtnCollection()
    {
        buttonCollection.SetActive(true);
    }

    public void OnClickNextStage()
    {
        //Ŭ���� ��ư ������Ʈ ��������
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        //���� ���� ���ϴ� �ε���
        int stageIndex = 0;
        switch (btnName)
        {
            case "House":
                stageIndex = 0;
                break;

            case "Spaceport":
                stageIndex = 2;
                break;

            case "Community":
                stageIndex = 3;
                break;

            case "Park":
                stageIndex = 4;
                break;

            case "BloodShop":
                break;

            case "Market":
                break;
            default:
                break;
        }
        background.material = backMat[stageIndex];

        buttonCollection.SetActive(false);
    }
}
