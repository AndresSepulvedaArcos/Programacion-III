using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public struct FCharacterData
{
    public int level;
    public float hp;
    public string name;
    public FPower[] power;

}
[System.Serializable]
public struct FPower
{
    public int level;
    public float damage;
    public Sprite icon;
}

[System.Serializable]
public class CharacterData
{
    public int level;
    public float hp;
    public string name;


}
