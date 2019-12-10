using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    float axisHor;
    KeyCode jumpKey;
    int canJump;
    Rigidbody2D r;
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        jumpKey = KeyCode.Space;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(jumpKey) && canJump > 0) {
            r.AddRelativeForce(new Vector2(0,500));
            canJump -= 1;
        }
        axisHor = Input.GetAxis("Horizontal") * 15f * Time.deltaTime;
        transform.Translate(axisHor,0,0);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Floor") {
            canJump = 2;
        }
    }
}
