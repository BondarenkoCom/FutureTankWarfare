using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float newSpeed = 4.0f;
    GameObject Player;

    TouchInputModule touchInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //        transform.Translate(Vector2.left * Time.deltaTime * newSpeed);

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector2.left * Time.deltaTime * newSpeed);
    }
}
