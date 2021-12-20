using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour
{

    private GameObject bola;
    public Rigidbody rig;
    public float speed = 100f;

    public void Start()
    {
        bola = GameObject.Find("Bola");
        rig = bola.GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
        {
            bola.GetComponent<MeshRenderer>().material.color = Color.grey;
        }
    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rig.velocity = Vector3.left * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rig.velocity = Vector3.right * speed * Time.deltaTime;
        }
    }
}
