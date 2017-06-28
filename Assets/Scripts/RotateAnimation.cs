using UnityEngine;
using System.Collections;

public class RotateAnimation : MonoBehaviour
{
    public float speed = 10f;
    
    private void Start()
    {
 

        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
       
    }
}