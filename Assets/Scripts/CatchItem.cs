using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchItem : MonoBehaviour
{
    public int pontuacao;
    public Text textoPontuacao;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Esfera")
        {
            pontuacao += 10;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        textoPontuacao.text = "x " + pontuacao.ToString();
    }
}
