using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] Crash c;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="floor" && c.tap)
            ps.Play();
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        ps.Stop();
    }
}
