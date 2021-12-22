using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    // Start is called before the first frame update
    addpoint a;
    void Start()
    {
        a= GameObject.FindObjectOfType<addpoint>();
        Destroy(gameObject,10);
    }
    public float turnspeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != "viking")
        {
            return;
        }
        a.add(10);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnspeed * Time.deltaTime);
    }
}
