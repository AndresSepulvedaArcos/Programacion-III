using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CandyCrush
{
    public class TileExplosion : Tile
    {


        protected override void OnMouseDown()
        {
            Debug.Log("explotar");
            boardManager.DestroyAround(candyData);

        }
    }

}
