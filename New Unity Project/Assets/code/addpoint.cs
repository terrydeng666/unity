using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public bool start = false;
    int point = 0;
    int time = 0;
    void Start()
    {
        
    }
    public void add(int x)
    {
        point+=x;
        score.text = point.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            start = true;
        }
        if (!start) return;
        time++;
        if (time % 100 == 0)
        {
            add(1);
        }
    }
}
