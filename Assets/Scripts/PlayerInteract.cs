using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Camera cam;
    [SerializeField]
    float distance = 2f;
    [SerializeField]
    LayerMask layerMask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(cam.transform.position,cam.transform.forward);
        Debug.DrawRay(ray.origin,ray.direction * distance);
        
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo,distance, layerMask))
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null) 
            {
                //Debug.Log(hitInfo.collider.GetComponent<Interactable>().promptMessage);
                hitInfo.collider.GetComponent<Interactable>().BaseInteract();
            }
        }
    }
}
