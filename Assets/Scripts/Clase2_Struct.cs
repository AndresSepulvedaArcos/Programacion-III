using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public struct FDataA
{
    public int X;
}

public class DataB
{
    public int X;
}


public class Clase2_Struct : MonoBehaviour
{
    public FCharacterData characterData;

    public CharacterData characterObject;
    /// <summary>
    /// heap y stack
    /// Garbage collector -> Daemon
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log(characterData.level);

        //Debug.Log(characterObject.level);

        FDataA dataA;
        dataA.X = 1;
        Debug.Log(dataA.X);
        FDataA dataAClon;
        dataAClon = dataA;
        dataA.X = 2;
        Debug.Log(dataA.X);
        Debug.Log(dataAClon.X);

        DataB dataB = new DataB();
        dataB.X = 1;
        Debug.Log(dataB.X);
        DataB dataBClon = dataB;
        dataB.X = 2;

        Debug.Log(dataB.X);
        Debug.Log(dataBClon.X);




    }


}
