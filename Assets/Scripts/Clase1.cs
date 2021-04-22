using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
public class Clase1 : MonoBehaviour
{

    //Ambito de la variable
    //Ambito global
    //IL2CPP
    public int entero;
    private float flotante = 1f;

    public string nombrePersonaje = "Pedrita";
    public Vector3 posicion;
    public byte streamingData;
    public bool[] switches;
    protected Input input;
    public EFrutas frutas;

    public EEnemyStates enemyStates;

    // Start is called before the first frame update
    void Start()
    {
        //ambito local
        float tempPercent = 10;


        //acceder o leer un enum
       
        if(frutas== EFrutas.Manzana)
        {
            Debug.Log(" hay manzanas ");
            Debug.Log(tempPercent);
        }

        if(10 == entero)
        {
            Debug.Log(" entero es 10 ");
        }

        //if anidados
        if(enemyStates==EEnemyStates.Idle)
        {
            Debug.Log(" Idle from IF");
        }else if(enemyStates== EEnemyStates.Chase)
        {
            Debug.Log(" Chase  from IF");
        }
        else if(enemyStates== EEnemyStates.Patrol)
        {
            Debug.Log(" Patrol  from IF");
        }///.....


        switch (enemyStates)
        {
            case EEnemyStates.Idle:
                Debug.Log(" Idle from switch");
                break;
            case EEnemyStates.Patrol:
                Debug.Log(" Patrol from switch");
                break;
            case EEnemyStates.Chase:
                Debug.Log(" Chase from switch");
                break;
           
                
          /*  default:
                Debug.Log(" this is default");
                break;*/
        }



    }

    // Update is called once per frame
    void Update()
    { 

    }
}
