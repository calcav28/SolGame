using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int ballsHit = 0;
    
    private void OnCollisionEnter2D(Collision2D coll) {
        Destroy(coll.gameObject);
        ballsHit += 1;
    }

    public int getBallsHit() {
        return ballsHit;
    }
}
