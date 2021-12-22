using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class groundspawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ground;
    public GameObject ground1;
    public GameObject ground2;
    public GameObject ground3;
    public GameObject cross1;
    public GameObject cross2;
    public Vector3 next;
    public Vector3 next1;
    public Vector3 next2;
    public int dir=1;
    public void spawn()
    {
        System.Random r = new System.Random();
        GameObject temp;
        int num = r.Next(2, 12);
        int odd= r.Next(0, 100);
        bool hole=true;
        bool turn = true;
        for (int i=0;i<num;i++)
        {
            if (odd>40 && hole && i!=0)
            {
                if(odd%2==1)
                {
                    temp = Instantiate(ground1, next, Quaternion.identity);
                }
                else
                {
                    if(dir==1 ||dir ==4)
                    {
                        temp = Instantiate(cross1, next, Quaternion.identity);
                    }
                    else
                    {
                        temp = Instantiate(cross2, next, Quaternion.identity);
                    }
                }
                hole = false;
            }
            else if(odd < 40 && i>3 && i<num-2 && turn)
            {
                int type = odd % 2;
                if(type==0)
                {
                    temp = Instantiate(ground, next, Quaternion.identity);
                    switch (dir)
                    {
                        case 1:
                            dir = 2;
                            break;
                        case 2:
                            dir = 4;
                            break;
                        case 3:
                            dir = 1;
                            break;
                        case 4:
                            dir = 3;
                            break;
                    }
                }
                else
                {
                    temp = Instantiate(ground, next, Quaternion.identity);
                    switch (dir)
                    {
                        case 1:
                            dir = 3;
                            break;
                        case 2:
                            dir = 1;
                            break;
                        case 3:
                            dir = 4;
                            break;
                        case 4:
                            dir = 2;
                            break;
                    }
                }
                temp = Instantiate(ground, next, Quaternion.identity);
                next = temp.transform.GetChild(dir).transform.position;
                turn = false;
            }
            else
            {
                temp = Instantiate(ground, next, Quaternion.identity);
            }
            next = temp.transform.GetChild(dir).transform.position;
            odd = r.Next(0, 100);
        }
        if (dir == 1 || dir == 4)
        {
            temp = Instantiate(ground2, next, Quaternion.identity);
            next1 = temp.transform.GetChild(2).transform.position;
            next2 = temp.transform.GetChild(3).transform.position;
        }
        else
        {
            temp = Instantiate(ground3, next, Quaternion.identity);
            next1 = temp.transform.GetChild(2).transform.position;
            next2 = temp.transform.GetChild(3).transform.position;
        }
        
    }
    void Start()
    {
        spawn();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
