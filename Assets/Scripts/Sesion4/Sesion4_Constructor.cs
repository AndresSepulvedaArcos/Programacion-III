using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character:IDamageable
{
    protected float internalHp;
    protected float internalBaseHp;

    public Character()
    {
        internalHp= internalBaseHp = 5;

    }

    public  Character(float NewHp)
    {
        internalHp = internalBaseHp = NewHp;

    }


    public float hp
    {
        get { return internalHp; }

        set { internalHp = Mathf.Clamp(value, 0, internalBaseHp); }
    }

    public void ApplyDamage(float Damage)
    {
        hp -= Damage;
        Debug.Log("applye damage in character"+hp);
    }
}

public class Orc:Character
{

    public bool killHobbitMode;

    public Orc(float NewHp)
    {
        internalHp = internalBaseHp = NewHp;
    }
    public Orc(float NewHp, bool HobbitMode=false)
    {
        internalHp = internalBaseHp = NewHp;
        killHobbitMode = HobbitMode;
    }


    public void InitializeOrc()
    {

    }
    
}

public class Sesion4_Constructor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Character player = new Character();
        Orc orcWhiteHand = new Orc(12);
        Orc orcBlackHand = new Orc(50, true);

        orcWhiteHand.InitializeOrc();

        Debug.Log(player.hp);
        Debug.Log(orcWhiteHand.hp);
        Debug.Log(orcBlackHand.hp);
    }

   
}
