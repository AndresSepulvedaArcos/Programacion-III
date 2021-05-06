using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CandyCrush
{
    public class BoardManager : MonoBehaviour
    {

        public Vector2Int boardSize = new Vector2Int(7, 7);
        public float tileOffSet = 1.5f;
        public GameObject tilePrefab;

        public Tile[,] tiles;

        // Start is called before the first frame update
        void Start()
        {
            InitializeBoard();
        }

        void InitializeBoard()
        {

            Vector2 tilePosition = Vector2.zero;
            GameObject tile;
            Vector2Int boardPosition = Vector2Int.zero;

            tiles = new Tile[boardSize.x, boardSize.y];

            for (int x = 0; x < boardSize.x; x++)
            {
                for (int y = 0; y < boardSize.y; y++)
                {
                    tilePosition.x = x* tileOffSet;
                    tilePosition.y = y* tileOffSet;

                    boardPosition.x = x;
                    boardPosition.y = y;

                    tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity);


                    tile.GetComponent<Tile>().Initialize(this, boardPosition);

                    tiles[x, y] = tile.GetComponent<Tile>();

                }
            }

        }

        bool CheckSwipe(CandyData candyData,out Tile swapedTile,out Tile originalTile)
        {
            swapedTile = originalTile = null;
            Vector2Int boardPositionTemp = candyData.boardPosition;

            switch (candyData.swipeDirection)
            {
                case EDirections.Up:
                    boardPositionTemp.y++;
                    break;
                case EDirections.Right:
                    boardPositionTemp.x++;
                    break;
                case EDirections.Down:
                    boardPositionTemp.y--;
                    break;
                case EDirections.Left:
                    boardPositionTemp.x--;
                    break;
                
            }

            
            if (boardPositionTemp.x < 0 || boardPositionTemp.y < 0 || boardPositionTemp.x >= boardSize.x || boardPositionTemp.y >= boardSize.y)
                return false;


              swapedTile = tiles[boardPositionTemp.x, boardPositionTemp.y];
              originalTile = tiles[candyData.boardPosition.x, candyData.boardPosition.y];
           
            tiles[boardPositionTemp.x, boardPositionTemp.y] = originalTile;
            tiles[candyData.boardPosition.x, candyData.boardPosition.y] = swapedTile;


            originalTile.ChangeBoardPosition(boardPositionTemp, tileOffSet);
            swapedTile.ChangeBoardPosition(candyData.boardPosition, tileOffSet);



            return true;
        }

        void SearchCombo(CandyData candyData)
        {
            //busqueda horizontal derecha
            for (int x = candyData.boardPosition.x; x < boardSize.x; x++)
            {

                if (tiles[x, candyData.boardPosition.y] == null)
                    break;


                if (tiles[x, candyData.boardPosition.y].candyData.candyType != candyData.candyType)
                    break;


                if (tiles[x, candyData.boardPosition.y].candyData.candyType == candyData.candyType)
                {
                    tiles[x, candyData.boardPosition.y].DestroyTile();

                }

            }
            //busqueda horizontal izquierda
            for (int x = candyData.boardPosition.x; x >= 0; x--)
            {
                if (tiles[x, candyData.boardPosition.y] == null)
                    break;


                if (tiles[x, candyData.boardPosition.y].candyData.candyType != candyData.candyType)
                    break;


                if (tiles[x, candyData.boardPosition.y].candyData.candyType == candyData.candyType)
                {
                    tiles[x, candyData.boardPosition.y].DestroyTile();

                }

            }

            //busqueda vertical arriba
            for (int y = candyData.boardPosition.y; y < boardSize.y; y++)
            {

                if (tiles[candyData.boardPosition.x, y] == null)
                    break;
                else
                if (tiles[candyData.boardPosition.x, y].candyData.candyType != candyData.candyType)
                    break;
                else
                if (tiles[candyData.boardPosition.x, y].candyData.candyType == candyData.candyType)
                {
                    tiles[candyData.boardPosition.x, y].DestroyTile();

                }

            }
            //busqueda vertical abajo
            for (int y = candyData.boardPosition.y; y >= 0; y--)
            {

                if (tiles[candyData.boardPosition.x, y] == null)
                    break;
                else
                if (tiles[candyData.boardPosition.x, y].candyData.candyType != candyData.candyType)
                    break;
                else
                if (tiles[candyData.boardPosition.x, y].candyData.candyType == candyData.candyType)
                {
                    tiles[candyData.boardPosition.x, y].DestroyTile();

                }

            }

        }

        public void CheckCombo(CandyData candyData)
        {

            Tile originalTile, swapedTile;
            if(CheckSwipe(candyData,out originalTile,out swapedTile))
            {
                SearchCombo(originalTile.candyData);
                SearchCombo(swapedTile.candyData);

            } 
            //despues de esto
            //aqui deberia haber un codigo que refill
            ///para hacer refill debo buscar los espacios que estan ==null
            
        }


        public void DestroyAround(CandyData candyData)
        {
            ///Implementar buscar alrededor de 3 alrededor y destruir
            ///
        }
       
    }

}


