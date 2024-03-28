using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD instance;
    public TMP_Text nivelTxt;
    public Image xpBar, lifeBar;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        SetNivel();
        SetXP();
        SetLife();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetXP()
    {
        xpBar.fillAmount = (float)PlayerStats.xp / (float)PlayerStats.xpToNextLevel;
    }
    public void SetLife()
    {
        lifeBar.fillAmount = (float)PlayerStats.Instance.GetLife() / (float)PlayerStats.Instance.lifeMax;
    }

    public void SetNivel()
    {
        //nivelTxt.text = "Lv " + PlayerStats.nivel;
        nivelTxt.text = $"Lv {PlayerStats.nivel}";
    }
}
