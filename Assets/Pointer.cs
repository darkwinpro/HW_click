
using UnityEngine;
using UnityEngine.Serialization;

public class Pointer : MonoBehaviour
{
    public Transform cameraTransform;
    public float size = 0.02f;
    

    private void LateUpdate()
    {
        float scale = Vector3.Distance(transform.position, cameraTransform.position);
        transform.localPosition = Vector3.one * (scale * size);
        
    }
}
