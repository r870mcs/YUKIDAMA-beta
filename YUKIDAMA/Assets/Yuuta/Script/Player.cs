using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
#endif
        gameObject.transform.localScale =new Vector3(hp,hp,hp);//hpに基づくscaleの計算

        if (transform.localScale.x<=0.5f)
        {
            transform.localScale = new Vector3(0, 0, 0);
            Destroy(gameObject);
        }

        gameObject.GetComponent<Rigidbody>().mass = hp*1.5f;
        Debug.Log(!gameObject.GetComponent<Rigidbody>().IsSleeping());
    }//Update
}
