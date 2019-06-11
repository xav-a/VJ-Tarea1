using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreate : MonoBehaviour
{
    //Camera camera;

    public GameObject itemPrefab;
    public GameObject parent;

    void Start()
    {

    }



    public void Update()
    {
        bool clickedButton1 = Input.GetMouseButtonDown(0);
        bool clickedButton2 = Input.GetMouseButtonDown(1);

        if (clickedButton1 || clickedButton2)
        {
            Vector3 clickPosition = Camera
                            .main
                            .ScreenToWorldPoint(Input.mousePosition);

            clickPosition = new Vector3(clickPosition.x, clickPosition.y, 0);
            GameObject copy = Instantiate(
                        itemPrefab,
                        clickPosition,
                        Quaternion.identity);
            copy.transform.parent = parent.transform;
            PrefabComponent prefab = copy.GetComponent<PrefabComponent>();

            if (clickedButton1)
            {
                prefab.animator.SetBool("Selection", true);
            }
            else
            {
                prefab.animator.SetBool("Selection", false);
            }


        }
    }


}
