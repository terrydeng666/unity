using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor4 : MonoBehaviour
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
        groundsp.next = groundsp.next2;
        groundsp.dir = 1;
        groundsp.spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }
}