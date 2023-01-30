using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    public int Health;

    public abstract void HealAbility();

    public abstract void Attack1();

    public abstract void Attack2();

}

