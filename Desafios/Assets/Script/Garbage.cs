using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : MonoBehaviour
{
    public float speed = 2f;

    void Start()
    {
        transform.localScale = transform.localScale * 2;
        transform.position += Vector3.forward * 2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.forward * Time.deltaTime;
        transform.position += Vector3.forward * 2 *Time.deltaTime;
    }
}
