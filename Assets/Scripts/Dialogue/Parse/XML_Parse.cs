using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;

[System.Serializable]
public class StringSprite : SerializableDictionary<string, Sprite> { }

public class XML_Parse : MonoBehaviour
{
    int _DialogueCount = 0; //받아오는 카운트
    Dialogue dialogue;      
    
    //0: 해미누리
    //1: 새미누리
    [SerializeField] 
    Sprite[] characterImgs;
   

    void Awake()
    {
      
    }

    public Dialogue LoadXML(string _storyFile)
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("XML/Dialogue");
        _DialogueCount = -1;

        XmlDocument xmlDoc = new XmlDocument();

        xmlDoc.LoadXml(txtAsset.text);
        XmlNodeList all_nodes = xmlDoc.SelectNodes("dataroot/" + _storyFile);

        dialogue = new Dialogue(new string[all_nodes.Count], new string[all_nodes.Count],new Sprite[all_nodes.Count]);

        dialogue.sentences = new string[all_nodes.Count];
        Debug.Log(all_nodes.Count);
       

        foreach (XmlNode node in all_nodes)
        {
            dialogue.sentences[++_DialogueCount] = node.SelectSingleNode("Dialogue").InnerText;
            SetName(node);
            SetImage(node);
        }


        return dialogue;
    }

    private void SetName(XmlNode node)
    {
        var name = node.SelectSingleNode("Name").InnerText;
        
        dialogue.names[_DialogueCount] = name;
    }

    private void SetImage(XmlNode node)
    {
        var name = node.SelectSingleNode("Name").InnerText;
        switch (name)
        {
            case "새미누리":
                dialogue.img[_DialogueCount] = characterImgs[0];
                break;
            case "해미누리":
                dialogue.img[_DialogueCount] = characterImgs[1];
                break;

            default:
                dialogue.img[_DialogueCount] = null;
                break;
        }

    }
}