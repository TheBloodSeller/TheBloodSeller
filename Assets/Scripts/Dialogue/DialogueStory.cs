using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueStory : MonoBehaviour
{
    [SerializeField]
    GameObject productsBar;

    Dictionary<int, Dialogue> dreamText;
    Dictionary<string, Dialogue> buttonText;

    void Generate()
    {

        buttonText.Add("����", new Dialogue("", new string[] { "2270�� �����",
                                                              "�¾�� ��Ȯ�� 10000�� �Ǵ� ���̴����� ���õ� ��� ���� �Ͼ��.",
                                                              "�׳�� ������ �༺�� �����ִ�.",
                                                              "�׳�� �� �༺�� ������ ���� ���� ���� �Ѵ�.",
                                                              "�׳�� ���� �����ҿ� ���� ������ �� �� �̴�."
                                                               }));

        buttonText.Add("����", new Dialogue(" ", new string[] { "���忡 ���� ������� �ִ�",
                                                                "��� �м��� �߽ɿ� �������� �ִ�.",
                                                                "������ �Ĵ� �� ������... �ѹ� �� ����?"}));

        buttonText.Add("���װ�����", new Dialogue(" ", new string[] { "���̴����� ��ȣ��迡 �ȳ��� ���� ä���ǿ� �����ߴ�" ,
                                                                     "Ȧ�α׷����� Ȯ�μ��� �������, ���̴����� ���� ��� �÷ȴ�.",
                                                                     "���� ä��Ⱑ ���̴����� �� ���� ��� ��������."}));

        buttonText.Add("����ä��Ұ���", new Dialogue(" ", new string[] { "����ä��Ⱑ ���̴����� ��ĵ�ϴ�, ����Ϳ� ������ â�� ����.",
                                                                         "�ᱹ ���̴����� ������� ���� �� �ۿ� ������." }));

        buttonText.Add("����ä�밡��", new Dialogue(" ", new string[] { "����ä��Ⱑ ���̴����� ��ĵ�ϴ�, ����Ϳ� �ʷϻ� â�� ����.",
                                                                       "���̴����� �Ǹ� 500ml ����.",
                                                                       "���̴����� ���忡 5000ũ������ ���Դ�"}));

        buttonText.Add("�ױ�", new Dialogue(" ", new string[] {"���̴����� �°��⸦ ����.", 
                                                               "���� ���� ����������.",
                                                               "ž�±��� �� ���� �����׷��� �������.",
                                                               "���̴����� ������ ������ ��ǥ�� �տ� ����."}));
                                                                    
        buttonText.Add("��", new Dialogue(" ", new string[] {"���̴����� ��ģ���� �̲��� ������ �� �� ħ�뿡 ������.",
                                                             "â�� ���� ���ڸ��� ���鼭 ������ ���� ���.",
                                                             "���� �ڰ� �Ͼ�� ���� �����ϴ�"}));

        buttonText.Add("����", new Dialogue(" ", new string[] {"���̴����� ����ǰ�� �緯 �������� ����."}));


        //���̾߱�
        


    }

    void Awake()
    {
        dreamText = new Dictionary<int, Dialogue>();
        buttonText = new Dictionary<string, Dialogue>();
        Generate();

    }
    void Start()
    {
        productsBar.SetActive(false);
    }


    public void Move_Start()
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["����"];
    }

    public void Move_Park()
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["����"];
        //����
        int a, b, c;
        a = Random.Range(1, 10);
        b = Random.Range(1, 10);
        c = Random.Range(1, 10);
    }

    public void Move_Bloodshop(int blood,int hp)
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["���װ�����"];
        if(blood < 3600)
        {

        }

    }

    public void Move_Spaceport()
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["�ױ�"];
    }

    public void Move_House(int hp, int hungry,int blood)
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["��"];
        SystemManager.Instance.Hero.SetHp(hungry >= 5 ? hp + 3: hp + 1);
        SystemManager.Instance.Hero.SetBlood(hungry >= 5 ? blood + 3: blood + 1);
    }

    public void Move_Market(int money,int hungry)
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["����"];
        
        productsBar.SetActive(true);
    }
}
