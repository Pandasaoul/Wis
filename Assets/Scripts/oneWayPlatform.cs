using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneWayPlatform : MonoBehaviour
{
    public bool isUp;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        transform.parent.GetComponent<Collider2D>().enabled = isUp;
    }

}
