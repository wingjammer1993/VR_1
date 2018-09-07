using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClick : MonoBehaviour
{

    public Fpf ballprefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fpf ball = Instantiate<Fpf>(ballprefab);
            ball.transform.localPosition = transform.position;
            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(500, 750));

        }
    }
}