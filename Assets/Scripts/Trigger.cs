using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private bool isRot;
    [SerializeField] private GameObject Ima;

    // Start is called before the first frame update
    void Start()
    {
        isRot = false;
    }

    // Update is called once per frame
    void Update()
    {
        Rot();
    }

    void Rot()
    {
        if (isRot == true)
        {
            Ima.gameObject.transform.Rotate(new Vector3(0, 0, 5 * Time.deltaTime));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isRot= true;
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isRot = false;
        }
    }
}
