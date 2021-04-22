using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase2_While : MonoBehaviour
{
    public float counter;

    WaitForSeconds wait = new WaitForSeconds(2);
    public float waitTime;

    public CharacterData character;

    // Start is called before the first frame update
    //CPU  Threadsssss

    private void OnEnable()
    {
        wait = new WaitForSeconds(waitTime);
    }
    void Start()
    {

      
         //blocking while
        /* while(counter<10000)
         {

             Debug.Log(counter);
             counter += Time.deltaTime;

         }
        */

       /* do
        {

            Debug.Log(counter);
            counter += Time.deltaTime;
        } while (counter < 0);

         */
        
      //  StartCoroutine(NonBlockingThread());

    }
    void BlockingWhile()
    {
        while (counter < 10000)
        {

            Debug.Log(counter);
            counter += Time.deltaTime;

        }
    }

    IEnumerator NonBlockingThread()
    {
        WaitForEndOfFrame endOfFrame = new WaitForEndOfFrame();
        while (true)
        {

            Debug.Log("my custom update");
            
            yield return endOfFrame;

        } 

    }

   
}
