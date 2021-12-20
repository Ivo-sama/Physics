using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour
{
    public Rigidbody Rig;

    public void Start()
    {
        Rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision coll)
    {

        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("Sai de cima, idiota!");
    }
}
