using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreate : MonoBehaviour
{
    //Camera camera;

    public GameObject itemPrefab;
    public GameObject tileMap;
    public int rayDistance = 10;

    void Start()
    {
        //worldCamera = GetComponent<Camera>();
    }



    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log($"click happens at {clickPosition.x}, {clickPosition.y}");
            clickPosition = new Vector3(clickPosition.x, clickPosition.y, 0);
            GameObject copy = Instantiate(
                        itemPrefab,
                        clickPosition,
                        Quaternion.identity);
            copy.transform.parent = tileMap.transform;
        }
    }


}
