using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class CheatingWall : MonoBehaviour {

    public Throwable th;

    // Use this for initialization
    void Start()
    {
        th = GetComponent<Throwable>();

    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Ball") && th.IsAttached())
        {
            WaitTime();
            Destroy(col.gameObject);
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1); //Wait 1 second then destroy it
    }
}
