using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projetil;
    public GameObject gauge;
    // Start is called before the first frame update
    private Rigidbody projetilRig;
    private float projetilSpeed = 200f;
    void Start()
    {
        gauge = GameObject.Find("Gauge");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bala = Instantiate(projetil);
            bala.transform.position = gauge.transform.position;
            gauge.transform.rotation = gameObject.transform.rotation;
            bala.GetComponent<Rigidbody>().AddForce(transform.forward * projetilSpeed, ForceMode.Impulse);
        }
    }
}
