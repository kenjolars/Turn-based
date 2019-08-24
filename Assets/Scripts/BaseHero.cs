﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseHero : MonoBehaviour
{
    //variables
    public new string name;

    public float baseHP;
    public float curHP;

    public float baseMP;
    public float curMP;

    public int stamina;
    public int intellect;
    public int dexterity;
    public int agility;
}
