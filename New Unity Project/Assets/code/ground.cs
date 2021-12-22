using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    // Start is called before the first frame update
    groundspawn groundsp;
    public GameObject coin;
    void Start()
    {
        groundsp = GameObject.FindObjectOfType<groundspawn>();
        
        spawncoin();
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawncoin()
    {
        int coinspawn = 2;
        for(int i=0;i<coinspawn;i++)
        {
            GameObject temp = Instantiate(coin);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(Random.Range(collider.bounds.min.x, collider.bounds.max.x), Random.Range(collider.bounds.min.y, collider.bounds.max.y), Random.Range(collider.bounds.min.z, collider.bounds.max.z));
        if(point!= collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }
        point.y = 1;
        return point;
    }
}
