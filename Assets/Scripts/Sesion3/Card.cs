using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public enum EPokeType {Plant,Water,Fire,Rock,Electric,Psy}

[System.Serializable]
public class Pokemon
{
    public float Hp;
    public string name;
    public EPokeType pokeType;
    public Sprite portrait;


}




public class Card : MonoBehaviour
{
    public TextMeshPro nameText;
    public TextMeshPro hpText;
    public SpriteRenderer portrait;
    public SpriteRenderer frame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Initialize(Pokemon pokemon,Color color)
    {
        nameText.SetText(pokemon.name);
        hpText.SetText(pokemon.Hp.ToString());
        portrait.sprite = pokemon.portrait;
        frame.color = color;

    }
}
