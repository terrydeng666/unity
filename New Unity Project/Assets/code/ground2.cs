using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground2 : MonoBehaviour
{
    // Start is called before the first frame update
    groundspawn groundsp;
    void Start()
    {
        groundsp = GameObject.FindObjectOfType<groundspawn>();
        
    }

    private void OnTriggerExit(Collider collider1)
    {
        
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
