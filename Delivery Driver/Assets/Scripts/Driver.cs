using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 150f;
    [SerializeField] private float moveSpeed = 60f;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float stearAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, - stearAmount);
        transform.Translate(0,(Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime),0);
         
    }
}
