using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFire : MonoBehaviour
{
    private GameObject _mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        // get a reference to our main camera
        if (_mainCamera == null)
        {
            _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFire()
    {
        var ray = new Ray(_mainCamera.transform.position, _mainCamera.transform.forward);
        var rayColor = Color.red;
        var rayDistance = 2000.0f;
        if (Physics.Raycast(ray, out var hit, rayDistance))
        {
            rayColor = Color.green;
            Destroy(hit.collider.GetComponent<MeshRenderer>());
        }
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, rayColor, 1.0f);
    }
}
