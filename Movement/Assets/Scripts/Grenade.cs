using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public Transform pin;
    public GameObject explosionPrefab;
    Animator animator;
    bool triggered = false;
    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Activate();
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //        Deactivate();
    //}
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Activate()
    {
        if (triggered) return;
        triggered = true;
        animator.SetTrigger("PullPin");
    }

    public void Deactivate()
    {
        animator.SetTrigger("Release");
        Invoke("Explode", 3f);
    }

    public void ReleasePin()
    {
        pin.parent = null;
    }

    private void Explode()
    {
        Instantiate(explosionPrefab).transform.position = transform.position;
        Destroy(gameObject);
    }
}
