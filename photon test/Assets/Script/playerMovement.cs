using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public float x;
    public float y;

    
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");

        y = Input.GetAxis("Vertical");
        transform.position += (Vector3)new Vector2(x * speed * Time.deltaTime, y * speed * Time.deltaTime);

    }
    private void FixedUpdate()
    {
        
    }
}
