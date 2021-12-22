using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{
    // Start is called before the first frame update
    groundspawn groundsp;
    //public GameObject coin;
    void Start()
    {
        groundsp = GameObject.FindObjectOfType<groundspawn>();

        //spawncoin();
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
