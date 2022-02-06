using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float t= 0f ;
    [SerializeField] ParticleSystem ps;
    //public bool sw = true;
    [SerializeField] PlayerController pc;
    [SerializeField] Crash c;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && c.tap)
        {
            c.tap = false;
            pc.sw = false;
           // Disable();
            ps.Play();
            FindObjectOfType<AudioSource>().Play();
            Invoke("Reload_Scene", t);
        }
    }
    void Reload_Scene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Finished");
    }
}
