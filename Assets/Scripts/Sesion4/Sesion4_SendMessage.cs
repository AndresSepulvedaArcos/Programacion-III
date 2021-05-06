using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesion4_SendMessage : MonoBehaviour
{
 
    
    public GameObject other;
    public GameObject otherWithNoScript;
    // Start is called before the first frame update
    void Start()
    {
        
        //envia el mensaje solo al objeto
        other.SendMessage("ShowMessageOk");

        //envia el mensajes hacia el dueño y los hijos
        other.BroadcastMessage("ShowMessageOk");

        //envia el mensaje al objeto, sino no encuentra, omite
        otherWithNoScript.SendMessage("ShowMessageOk",SendMessageOptions.DontRequireReceiver);

        //Envia el mensaje hacia los padres
        /* 
         * other.SendMessageUpwards("ShowMessageOk"); 
         */
    }

     
}
