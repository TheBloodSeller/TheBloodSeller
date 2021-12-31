using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;

    Player player => SystemManager.Instance.Player;

    void Start()
    {
        panel.SetActive(false);
    }

    public void PanelOpenOnclick()
    {
        panel.SetActive(true);
    }
    
    public void ContinueOnclick()
    {
        panel.SetActive(false);
    }

    public void SaveOnclick()
    {
        PlayerPrefs.SetInt("HP",player.HP);
        PlayerPrefs.SetInt("Blood",player.Blood);
        PlayerPrefs.SetInt("Hunger",player.Hunger);
        PlayerPrefs.SetInt("Money",player.Money);
    }

    public void LoadOnClick()
    {
        player.HP = PlayerPrefs.GetInt("HP");
        player.Blood = PlayerPrefs.GetInt("Blood");
        player.Hunger = PlayerPrefs.GetInt("Hunger");
        player.Money = PlayerPrefs.GetInt("Money");
    }

    public void EndOnclick()
    {
        Application.Quit();
    }
}
