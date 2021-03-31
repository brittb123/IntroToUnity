using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float FlapForce = 5.0f;
    AudioSource JumpAudio;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            Destroy();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetButtonDown("Flap"))
           _rigidbody.AddForce(new Vector3(0, FlapForce, 0), ForceMode.Impulse);
    }
}
