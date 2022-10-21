using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTheThing : MonoBehaviour
{
    public GameObject spinny;

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();

        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion spin = Quaternion.Euler(0, 0, angle);
        spinny.transform.rotation = spin;
    }
}
