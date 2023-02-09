using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
    // Update is called once per frame
    public float newSpeed = 4.0f;
    GameObject Player;

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch= Input.GetTouch(0);
            transform.Translate(Vector2.left * Time.deltaTime * newSpeed);
        }
    }
}
