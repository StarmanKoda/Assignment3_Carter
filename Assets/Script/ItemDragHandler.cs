using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public Vector3 StartPosition;
    public Transform DropPosition;
    public GameObject ObjectToSpawn;
    public ParticleSystem particle;
    public bool roof;
    public float mZcord;
    public float Xoffset;
    public float Yoffset;
    private Vector3 mOffset;
    public Vector3 mousePoint;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (roof == true)
        {
            if (InventoryScript.Instance.amountroof > 0)
            {
                Instantiate(ObjectToSpawn, hit.point, Quaternion.identity);
                Instantiate(particle, hit.point, Quaternion.identity);
                transform.position = StartPosition;
                MusicScript.Instance.spawnnoise = true;
                InventoryScript.Instance.amountroof--;
            }
        }
        else
        {
            if (InventoryScript.Instance.amountwall > 0)
            {
                Instantiate(ObjectToSpawn, hit.point, Quaternion.identity);
                Instantiate(particle, hit.point, Quaternion.identity);
                transform.position = StartPosition;
                MusicScript.Instance.spawnnoise = true;
                InventoryScript.Instance.amountwall--;
            }
        }
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mousePoint = Input.mousePosition;
    }
}
