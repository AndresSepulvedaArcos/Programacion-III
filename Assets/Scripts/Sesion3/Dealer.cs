using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct FPoketypeColor
{
    public EPokeType pokeType;
    public Color color;
}
public class Dealer : MonoBehaviour
{

    public Pokemon[] pokeDex;

    public FPoketypeColor[] poketypeColors;
    public int draftSize = 6;

    public float offset = 2;
    public GameObject cardPrefab;


    // Start is called before the first frame update
    void Start()
    {
        ChooseRandomCards();   
    }

    public Color GetPokeColor(EPokeType pokeType)
    {
        for (int i = 0; i < poketypeColors.Length; i++)
        {
            if (poketypeColors[i].pokeType == pokeType)
                return poketypeColors[i].color;
        }

        
        return Color.black;
    }

    public void ChooseRandomCards()
    {

        Vector3 targetPosition = Vector3.zero;
        GameObject card;
        for (int i = 0; i < draftSize; i++)
        {
            int randomIndex = Random.Range(0, pokeDex.Length);
            Pokemon pokemon = pokeDex[randomIndex];

            targetPosition.x = i* offset;
             card=Instantiate(cardPrefab, targetPosition, Quaternion.identity);

            card.GetComponent<Card>().Initialize(pokemon,GetPokeColor(pokemon.pokeType));

        }
     
         

    }
   
}
