using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] ParticleSystem ps, ss;
    [SerializeField] float t = 0f;
    [SerializeField] PlayerController pc;
    SurfaceEffector2D sd;
    public bool tap = true;
    private void Start()
    {
        sd = FindObjectOfType<SurfaceEffector2D>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag=="floor" && tap)
        {
            tap = false;
            sd.speed = 0f;
            FindObjectOfType<AudioSource>().Play();
            ps.Play();
            Invoke("rs", t);
        }
    }

    void rs()
    {
        
        SceneManager.LoadScene(0);
        Debug.Log("Heavy Driver!!");
    }
}
