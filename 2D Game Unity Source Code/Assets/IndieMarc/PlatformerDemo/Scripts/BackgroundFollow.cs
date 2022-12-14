using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, 10f);
    [SerializeField] private Transform camera;

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.position + offset;
    }
}
