 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace CandyCrush
{

    public enum EDirections { Up,Right,Down,Left }

    [System.Serializable]
    public struct CandyData
    {
        public int candyType;
        public Vector2Int boardPosition;
        public EDirections swipeDirection;

    }

    public class Tile : MonoBehaviour
    {
        public CandyData candyData;
        public Sprite[] sprites;
        protected BoardManager boardManager;

        private Vector2 screenPosition;
        private Vector2 directionDifference;
        // Start is called before the first frame update
        void Start()
        {
            
        }

      

        protected virtual  void OnMouseDown()
        {
            screenPosition = Camera.main.WorldToScreenPoint(transform.position);


        }
        private void OnMouseDrag()
        {
              directionDifference = screenPosition;
            directionDifference.x = Input.mousePosition.x-screenPosition.x ;
            directionDifference.y = Input.mousePosition.y- screenPosition.y  ;

          
        }
        private void OnMouseUp()
        {
          
            if(Mathf.Abs(directionDifference.x)>Mathf.Abs(directionDifference.y))///es una movida horizontal
            {
                if (directionDifference.x > 0)
                    candyData.swipeDirection = EDirections.Right;
                else
                    candyData.swipeDirection = EDirections.Left;


            }else//es una movida vertical
            {

                candyData.swipeDirection = directionDifference.y > 0 ? EDirections.Up : EDirections.Down;
            }


              boardManager.CheckCombo(candyData);
        }

        public void Initialize(BoardManager boardManagerReference, Vector2Int NewBoardPosition)
        {
            boardManager = boardManagerReference;
            candyData.boardPosition = NewBoardPosition;


            InitializeRandomCandy();
        }
       
        void InitializeRandomCandy()
        {
            candyData.candyType = Random.Range(0, 5);

            GetComponent<SpriteRenderer>().sprite = sprites[candyData.candyType];

        }

        public void DestroyTile()
        {
            Destroy(gameObject);
        }

        public void ChangeBoardPosition(Vector2Int NewBoardPosition,float boardOffset)
        {
            candyData.boardPosition = NewBoardPosition;

            transform.position = new Vector2(NewBoardPosition.x * boardOffset, NewBoardPosition.y * boardOffset);

        }
    }
}

