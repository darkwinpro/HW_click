
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Hunter : MonoBehaviour
{
    //[SerializeField] private GameObject _test;
    public Transform Pointer;
    
    //public LayerMask LayerMask;

    private void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
       // ray.origin = transform.position;
       // ray.direction = transform.forward;
       // Debug.DrawRay(transform.position, transform.forward*5, Color.red);
       
        RaycastHit hit;
        
        
        if (Physics.Raycast(ray, out hit))
        {
            Pointer.position = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Come here!!!");
            }
        }
    }
}