using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float frc = 1f;
    [SerializeField] float base_speed = 20f;
    [SerializeField] float boost_speed = 30f;
    SurfaceEffector2D sf;
    public bool sw = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sf = FindObjectOfType<SurfaceEffector2D>();
    }
    void Update()
    {
        if(sw)
        {
            func_rotate();
            func_boost();
        }
        
    }
    void func_boost()
    {
        if (Input.GetKey(KeyCode.W))
        {
            sf.speed = boost_speed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            sf.speed = base_speed;
        }
    }

    
    void func_rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(frc * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque((-1) * frc * Time.deltaTime);
        }
    }
}
