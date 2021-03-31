using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementBehavior : MonoBehaviour
{
    public float Ymin;
    public float Ymax;
    public float HorizontalSpeed = 2;
    public float VerticalSpeed = 0;
    public float StartCos = 0;

 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, HorizontalSpeed) * Time.deltaTime;
        StartCos += Time.deltaTime;
        transform.position += new Vector3(0, Mathf.Cos(StartCos), 0) * HorizontalSpeed * Time.deltaTime;
    }
}
