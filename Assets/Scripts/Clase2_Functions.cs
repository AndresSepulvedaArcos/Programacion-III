using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase2_Functions : MonoBehaviour
{
    private int age = 2;
    public float hp = 20;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        Shoot();


        Debug.Log(Suma(2, 3)) ;
        Debug.Log(Suma(2.12312f, Time.deltaTime));
        Debug.Log(Suma(Vector3.right, Vector3.up));
       
      
        

        Debug.Log(Concatena("Andres", "Sepulveda"));

        GameObject objetoInstanciado=null;
        if(GenerateObject(ref   objetoInstanciado))
        {
            Debug.Log(objetoInstanciado);

        }
        GameObject objetoInstanciado2;

        if (GenerateObjectOut(out objetoInstanciado2))
        {
            Debug.Log(objetoInstanciado2);
        }

      

    }

    public void Shoot()
    {
        Debug.Log("Shoot");

    }

    public int GetAge()
    {
        Debug.Log(age);

        return age;

    }

    public bool CheckHasDied()
    {
        if(hp<=0)
        {
            return true;
        }


        return false;
    }

    public int Suma(int A,int B)
    {
        int total = A + B;

        Debug.Log(total);
        return total;
    }

    public float Suma(float A,float B)
    {
        float total = A + B;
 
        return total;
    }

    public Vector3 Suma(Vector3 A, Vector3 B)
    {
        Vector3 total = A + B;
        return total;

    }

    public string Concatena(string Nombre,string Apellido)
    {
        string fullName = Nombre + "  " + Apellido;

        return fullName;
    }

    public bool GenerateObject(ref GameObject obj)
    {
        if (prefab == null) return false;

          obj=    Instantiate(prefab);


        return true;
    }

    public void ReadObject(in GameObject obj)
    {
        Debug.Log(obj);

    }

    public bool GenerateObjectOut(out GameObject obj)
    {
        obj = null;
        if (prefab == null) return false;

        obj = Instantiate(prefab);


        return true;
    }

}

 