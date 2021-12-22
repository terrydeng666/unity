using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Animator))]
public class vikingcontroller : MonoBehaviour
{
    addpoint a;
    public bool start = false;
    public bool end = true;
    public GameObject starttext;
    public GameObject enemy;
    public Text endtxt;
    public Vector3 Moving=Vector3.forward;
    public Vector3 Movingr = Vector3.right;
    public Vector3 Movingl = Vector3.left;
    [SerializeField]float movingspeed = 10;
    public float jumpforce=600;
    Rigidbody rb;
    bool run = false;
    Animator animator;
    //initailize
    void Awake()
    {
        //Debug.Log("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.FindObjectOfType<addpoint>();
        //Debug.Log("start");
        Transform t = GetComponent<Transform>();
        //MeshRenderer mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Moving = Vector3.forward;
        Movingr = Vector3.right;
        Movingl = Vector3.left;
        //t.position = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        run = false;
        animator.SetBool("run", run);
        if (!end) return;
        if (Input.GetKey(KeyCode.W))
        {
            Destroy(starttext);
            start = true;
        }
        if (!start) return;
        run = false;
        //transform.localPosition += movingspeed * Time.deltaTime * Moving;
        // Debug.Log("update");
        
        transform.localPosition += movingspeed * Time.deltaTime *Moving;
            run = true;
        
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.Rotate(90*Vector3.down);
            if (Moving == Vector3.forward)
            {
                Moving = Vector3.left;
                Movingl = Vector3.back;
                Movingr = Vector3.forward;
            }
            else if (Moving == Vector3.right) 
            {
                Moving = Vector3.forward;
                Movingr = Vector3.right;
                Movingl = Vector3.left;
            }
            else if(Moving==Vector3.left)
            {
                Moving = Vector3.back;
                Movingl = Vector3.right;
                Movingr = Vector3.left;
            }
            else
            {
                Moving = Vector3.right;
                Movingl = Vector3.forward;
                Movingr = Vector3.back;
            }
            //transform.localPosition += movingspeed * Time.deltaTime * Vector3.left;
            run = true;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.Rotate(90*Vector3.up);
            if (Moving == Vector3.forward)
            {
                Moving = Vector3.right;
                Movingl = Vector3.forward;
                Movingr = Vector3.back;
            }
            else if (Moving == Vector3.right)
            {
                Moving = Vector3.back;
                Movingl = Vector3.right;
                Movingr = Vector3.left;
            }
            else if (Moving == Vector3.left)
            {
                Moving = Vector3.forward;
                Movingr = Vector3.right;
                Movingl = Vector3.left;
            }
            else
            {
                Moving = Vector3.left;
                Movingl = Vector3.back;
                Movingr = Vector3.forward;
            }
            //transform.localPosition += movingspeed * Time.deltaTime * Vector3.right;
            run = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingspeed * Time.deltaTime * Movingl;
            run = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingspeed * Time.deltaTime * Movingr;
            run = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.AddForce(jumpforce * Vector3.up);
        }
        animator.SetBool("run", run);
        
    }
    void OnCollisionEnter(Collision collision)
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        
    }
    void OnCollisionExit(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "bar")
        {
            return;
        }
        enemy.transform.position = transform.position;
        enemy.transform.position -= Moving ;
        a.start = false;
        end = false;
        endtxt.text = "Game Over";
    }
}
