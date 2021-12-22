using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 Moving;
    [SerializeField] float movingspeed = 10;
    //initailize
    void Awake()
    {
        //Debug.Log("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("start");
        Transform t = GetComponent<Transform>();
        MeshRenderer mr = GetComponent<MeshRenderer>();

        t.position = Vector3.one + 3*Vector3.up+5*Vector3.back;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition += movingspeed * Time.deltaTime * Moving;
        // Debug.Log("update");
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += movingspeed * Time.deltaTime * Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += movingspeed * Time.deltaTime * Vector3.back;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingspeed * Time.deltaTime * Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingspeed * Time.deltaTime * Vector3.right;
        }
    }
}
