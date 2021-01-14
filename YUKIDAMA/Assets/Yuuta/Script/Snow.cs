using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    public float　recovery;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDamage()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player"&&!(collision.gameObject.GetComponent<Rigidbody>().velocity.magnitude==0))
        { 
            
            collision.gameObject.GetComponent<Player>().hp += recovery * (Time.deltaTime / 10f);//playerを回復させる処理
        }
    }
}
