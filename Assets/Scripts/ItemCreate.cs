using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreate : MonoBehaviour
{
    //Camera camera;
    public GameObject parent;
    GameObject itemPrefab;

    void Start()
    {
        itemPrefab = Resources.Load<GameObject>("Prefabs/Item");
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


            Animator itemAnimator = copy.GetComponent<Animator>();

            if (clickedButton1)
            {
                itemAnimator.SetBool("Selection", true);
            }
            else
            {
                itemAnimator.SetBool("Selection", false);
            }


        }
    }


}
