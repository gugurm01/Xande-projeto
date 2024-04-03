using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;
    public int xpIncrease = 10, lifeMax = 100;
    int life;
    public static int luck = 10;
    public static int nivel = 1;
    public static int xp, xpToNextLevel = 5;

    public UnityEvent OnPause, OnUnpause;
    private void Awake()
    {
        Instance = this;
        life = lifeMax;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
                OnUnpause.Invoke();
            }
            else
            {
                Time.timeScale = 0;
                OnPause.Invoke();
            }
        }
    }

    public static void GainXp(int xpGain)
    {
        xp += xpGain;
        HUD.instance.SetXP();
        if (xp >= xpToNextLevel)
        {
            PlayerStats.nivel++;
            xp = 0;
            xpToNextLevel += PlayerStats.Instance.xpIncrease;
            HUD.instance.SetXP();
            HUD.instance.SetNivel();
            print(xp + "/" + xpToNextLevel);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life -= collision.gameObject.GetComponent<Enemy>().damage;
            HUD.instance.SetLife();
            if(life <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public int GetLife()
    {
        return life;
    }
}
