using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet
{
    private float hiddenDamage;

    private bool hiddenSwitchEnable;



    public float damage {
        get {
            return hiddenDamage;              
        } 
    }

    public bool switchEnable
    {
        set { hiddenSwitchEnable = value; }
    }
}


public class Sesion4_Properties : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

        Bullet bullet = new Bullet();

        Debug.Log("damage is " + bullet.damage);


        bullet.switchEnable = true;

        Character character = new Character();

        character.hp = 100;



    }

    
};
