using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class CheatingWall : MonoBehaviour {

    public Throwable th;

    private void OnTriggerExit(Collider col)
    {
        
        if (col.CompareTag("Ball"))
        {
            th = col.gameObject.GetComponentInParent<Throwable>();
            if (th.IsAttached())
            {
                WaitTime();
                Destroy(col.gameObject);
                Instantiate(th.BallCreatorObject, th.BallCreatorPosition.position, th.BallCreatorPosition.rotation);
            }
        }

    }
 /*   private void OnTriggerEnter(Collider col)
    {
      
    }*/

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1); //Wait 1 second then destroy it
    }
}
