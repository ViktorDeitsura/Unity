using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PBStatsBar : MonoBehaviour
{
    private int HP;
    private int Kills;
    //public Animator animator;
    public Slider healthBar;
    public Text currentKills;

    void Update()
    {
        currentKills.text = "Kills: "+GetComponent<PBStats>().enemyKills;
        healthBar.value = GetComponent<PBStats>().health;
    }

}
