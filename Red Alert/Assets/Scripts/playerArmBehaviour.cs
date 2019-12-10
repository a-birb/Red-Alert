using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerArmBehaviour : MonoBehaviour
{
    float angle;
    Vector3 mousePositionInWorld;
    float speed = 8f;
    public GameObject target;

    void Update()
    {
        mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = (Mathf.Atan2(mousePositionInWorld.y - transform.position.y, mousePositionInWorld.x - transform.position.x) * Mathf.Rad2Deg);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle),speed * Time.deltaTime);

        transform.position = new Vector3(target.transform.position.x,target.transform.position.y,target.transform.position.z - 0.25f);
    }
}
