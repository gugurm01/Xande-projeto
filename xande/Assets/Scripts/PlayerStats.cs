using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //public static PlayerStats Instance;
    public static int nivel;
    public int xp, xpToNextLevel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public static void GainXp(PlayerStats status, int xpGain)
    {
        status.xp += xpGain;
        if (status.xp >= status.xpToNextLevel)
        {
            PlayerStats.nivel++;
        }
    }       
}
