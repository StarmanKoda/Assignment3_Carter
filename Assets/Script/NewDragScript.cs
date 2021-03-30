using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class NewDragScript : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZcord;
    public Rigidbody body;
    public bool roof;
    void OnMouseDown()
    {
        mZcord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZcord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        if (GravityManagement.Instance.gravityon == false)
            transform.position = GetMouseWorldPos() + mOffset;
    }
    void Start()
    {
        body.useGravity = false;
    }
    void Update()
    {
        if(GravityManagement.Instance.gravityon == true)
        {
            body.useGravity = true;
            body.constraints = RigidbodyConstraints.None;
            body.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
        }
    }
}
