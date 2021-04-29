using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Props : IDamageable
{

    public void ApplyDamage(float Damage)
    {
        Debug.Log("Show decal");
    }
}

public class Sesion4_Interfaces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

      //  SendMessage("ApplpyDamage", SendMessageOptions.DontRequireReceiver);
        gameObject.GetComponent<IDamageable>()?.ApplyDamage(12);
       

        Character character = new Character(12);
        character.ApplyDamage(12);

      
         


    }

    
}
