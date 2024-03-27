using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    [SerializeField] private GameObject m_balloonPrefab;
    [SerializeField] private float floatStrength;
    [SerializeField] private float growthRate = 1.5f;
    private GameObject m_balloon;
    private Rigidbody m_balloonRigidbody;
    void Update()
    {
        if (m_balloon != null)
        {
            GrowBalloon();
        }
    }

    private void GrowBalloon()
    {
        float growThisFrame = growthRate * Time.deltaTime;
        Vector3 changeScale = m_balloon.transform.localScale * growThisFrame;
        m_balloon.transform.localScale += changeScale;
    }

    public void ReleaseBalloon()
    {
        m_balloonRigidbody.isKinematic = false;
        m_balloon.transform.parent = null;
        Rigidbody rb = m_balloon.GetComponent<Rigidbody>();
        Vector3 force = Vector3.up * floatStrength;
        rb.AddForce(force);

        Destroy(m_balloon, 10f);
        m_balloon = null;
    }
    
    public void CreateBalloon(Transform parentHand)
    {
        m_balloon = Instantiate(m_balloonPrefab, parentHand);
        m_balloon.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        m_balloonRigidbody = m_balloon.GetComponent<Rigidbody>();
        m_balloonRigidbody.isKinematic = true;
    }
}
