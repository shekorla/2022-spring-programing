using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class weaponBase : MonoBehaviour
{
    // this is a template for a weapon, dont use this script directly
    public int powerLevel;

    public virtual void Attack()
    {
        
    }
}
