using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20;
    private float horizontal;
    private float vertical;
    public Rigidbody rb;
    public int force = 10;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontal);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
