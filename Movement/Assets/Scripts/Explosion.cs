using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float m_radius = 4f;
    [SerializeField] private float m_power = 10f;
    void Start()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, m_radius);
        if (colliders.Length < 1) return;
        foreach (Collider collider in colliders)
        {
            Target target = collider.GetComponent<Target>();
            if (target != null)
            {
                target.GetHit();
            }
        }
    }
}
