using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStory : MonoBehaviour
{
    Dialogue dialogue => SystemManager.Instance.DialogueTrigger.dialogue;

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
        buttonText.Add("���� ������", new Dialogue(" ", new string[] {"���̴����� ��ȣ��迡 �ȳ��� ���� ä���ǿ� �����ߴ�" ,
                                                                     "Ȧ�α׷����� Ȯ�μ��� �������, ���̴����� ���� ��� �÷ȴ�.",
                                                                     "���� ä��Ⱑ ���̴����� �� ���� ��� ��������."}));
        buttonText.Add("�ױ�", new Dialogue(" ", new string[] { "" }));
        buttonText.Add("��", new Dialogue(" ", new string[] { }));
        buttonText.Add("����", new Dialogue(" ", new string[] { }));


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
    }
}
