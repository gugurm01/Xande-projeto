using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;
    public int xpIncrease = 10, lifeMax = 100;
    int life;
    public static int nivel = 1;
    public static int xp, xpToNextLevel = 5;

    private void Start()
    {
        Instance = this;
        life = lifeMax;
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
        }
    }

    public int GetLife()
    {
        return life;
    }
}
