using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStory : MonoBehaviour
{

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
        buttonText.Add("���װ�����", new Dialogue(" ", new string[] {"���̴����� ��ȣ��迡 �ȳ��� ���� ä���ǿ� �����ߴ�" ,
                                                                     "Ȧ�α׷����� Ȯ�μ��� �������, ���̴����� ���� ��� �÷ȴ�.",
                                                                     "���� ä��Ⱑ ���̴����� �� ���� ��� ��������."}));
        buttonText.Add("�ױ�", new Dialogue(" ", new string[] { "���̴����� �°��⸦ ����.", 
                                                               "���� ���� ����������.",
                                                               "ž�±��� �� ���� �����׷��� �������.",
                                                               "���̴����� ������ ������ ��ǥ�� �տ� ����."}));
                                                                    
        buttonText.Add("��", new Dialogue(" ", new string[] {"���̴����� ��ģ���� �̲��� ������ �� �� ħ�뿡 ������.",
                                                             "â�� ���� ���ڸ��� ���鼭 ������ ���� ���."}));
        buttonText.Add("����", new Dialogue(" ", new string[] {"���̴����� ����ǰ�� �緯 �������� ����."}));


        //���̾߱�
        


    }
    void Start()
    {
        Generate();
    }

    void Awake()
    {
        dreamText = new Dictionary<int, Dialogue>();
        buttonText = new Dictionary<string, Dialogue>();
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
    }

    public void Move_Bloodshop()
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["���װ�����"];
    }

    public void Move_Spaceport()
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["�ױ�"];
    }

    public void Move_House(int hp)
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["��"];
        SystemManager.Instance.Hero.SetHp(hp);
    }

    public void Move_Market(int money)
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["����"];
    }
}
