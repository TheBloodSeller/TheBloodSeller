using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamDialogue : MonoBehaviour
{
    Dictionary<int, Dialogue[]> dreamDialogues;

    void Generate()
    {
        dreamDialogues.Add(1, new Dialogue[] { new Dialogue(" " ,new string[] {"���̴����� �¾�� 1160�� °",
                                                                              "���̴����� �ع̴����� ���Ŵ�.",
                                                                              "�׵��� Ȧ�α׷��� ����� ���ڵ��� �ϳ��� �о���."} ),
                                              new Dialogue("���̴���",new string[]{"��... ��... ��..." })});
    }

    void Awake()
    {
        dreamDialogues = new Dictionary<int, Dialogue[]>();
        Generate();
    }


    public void DreamStroy(int dream)
    {
        Dialogue[] dreamDialogue = dreamDialogues[dream];

        for (int i = 0; i < dreamDialogue.Length; i++)
        {
            SystemManager.Instance.DialogueManager.StartDialogue(dreamDialogue);
        }
    }

}
