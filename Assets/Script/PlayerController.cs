using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float belok;
    public float maju_mundur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        maju_mundur = Input.GetAxis("Vertical");
        //moving vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * maju_mundur);
        //moving vehicle right and left
        belok = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * belok) ;
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * belok);
    }
}
