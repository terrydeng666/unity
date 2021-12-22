using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor1 : MonoBehaviour
{
    // Start is called before the first frame update
    groundspawn groundsp;
    void Start()
    {
        groundsp = GameObject.FindObjectOfType<groundspawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "viking") return;
        groundsp.next = groundsp.next1;
        groundsp.dir = 2;
        groundsp.spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
