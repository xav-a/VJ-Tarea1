using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabComponent : MonoBehaviour
{
    //public Animator animator;
    // Start is called before the first frame update

    public Animator animator;

    void Awake() {
        animator = this.GetComponent<Animator>();
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


}
