using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeControls : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject player;
    private Transform playerPos;
    private GameObject target;
    private Transform targetPos;
    void Start()
    {
        player = GameObject.Find("Player");
        target = GameObject.Find("Target");
        playerPos = player.transform;
        targetPos = target.transform;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            targetPos.Rotate(-Vector3.up * 20f * Time.deltaTime);
        }

        StartCoroutine("QuatRotation");
    }

    IEnumerator QuatRotation()
    {
        /* O cubo player copia as coordenadas do cubo target, ficando os dois "olhando" para o mesmo lado.
         * yield return new WaitForSeconds(5f);
         * Vector3 pos = playerPos.position - targetPos.position;
         * player.transform.rotation = Quaternion.LookRotation(pos); */

        // Outra forma de fazer exatamente o mesmo...
        yield return new WaitForSeconds(0.2f);
        player.transform.rotation = Quaternion.Slerp(playerPos.rotation, targetPos.rotation, 2f);

    }
}
