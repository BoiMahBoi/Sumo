using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantCrab : Enemy
{

    public override void HealAbility()
    {
        if(Health <= 25)
        {
            // HEAL!!!
        }
    }

    public override void Attack1()
    {
        // Attack with right claw!
    }

    public override void Attack2()
    {
        // Shoot a stream of water!
    }

}

