using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueStory : MonoBehaviour
{
    [SerializeField]
    GameObject productsBar;

    Dialogue dialogue;

    Dictionary<int, Dialogue> dreamText;
    Dictionary<string, Dialogue> buttonText;

    [SerializeField]
    Player player => SystemManager.Instance.Player;

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
        dialogue = buttonText["����"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void Move_Park()
    {
        dialogue = buttonText["����"];
        //����
        int a, b, c;
        a = Random.Range(1, 10);
        b = Random.Range(1, 10);
        c = Random.Range(1, 10);
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void Move_Bloodshop(int blood,int HP)
    {
        dialogue = buttonText["���װ�����"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
        if (blood < 3600 || HP <= 3)
        {
            dialogue = new Dialogue("", new string[] { "���̴����� ���� �� ���Ƽ� �Ǹ� ���� �� ����"});
            SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
            return;
        }
        
    }

    public void Move_Spaceport()
    {
        dialogue = buttonText["�ױ�"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void Move_House(int hp, int hungry,int blood,int dream)
    {
        
        player.HP = hungry >= 5 ? hp + 3 : hp + 1;
        player.Blood = hungry >= 5 ? blood + 3: blood + 1;
        dialogue = buttonText["��"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);

        //���� ����
        SystemManager.Instance.DreamDialogue.DreamStroy(1);

    }

    public void Move_Market()
    {
        dialogue = buttonText["����"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
        productsBar.SetActive(true);
    }
}
