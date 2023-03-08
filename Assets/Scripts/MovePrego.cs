using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrego : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();   
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
        }
    }
}
