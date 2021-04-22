using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase1Arrays : MonoBehaviour
{
    public int[] mine;
    
    public int tamanoMinas = 12;
    public string[] nombres = new string[3];

    public bool[,] board;
    public int boardSizeX, boardSizeY;

    private int[] balas;
    public float chanceOfMines = .3f;

    public GameObject blockPrefab;
    public Material red;


    // Start is called before the first frame update
    void Start()
    {
        nombres[0] = "misifus";

        //fijar el tamaño reservado de memoria Heap para el arreglo
        mine = new int[tamanoMinas];

        for (int i = 0; i < mine.Length; i++)
        {
            mine[i] = Random.Range(0, 20);

        }

        /*
            xxxxxxxxxxxxxxxxxxx
            x
            x
            x

         */

        board = new bool[boardSizeX, boardSizeY];

        for (int x = 0; x < boardSizeX; x++)
        {
            for (int y = 0; y < boardSizeY; y++)
            {

                /* 0-true ----------0.5--------false ---------1    */
                /* if (Random.value<0.5f)
                  board[x, y] = true;
                  else
                      board[x, y] = false;*/

                board[x, y] = Random.value < chanceOfMines ? true : false;
                GameObject block=       Instantiate(blockPrefab, new Vector3(x, y, 0), Quaternion.identity);
                
                
                if (board[x,y])
                {

                    block.GetComponent<MeshRenderer>().sharedMaterial = red;

                }
                

            }
        }

          

       

    }
 
}
