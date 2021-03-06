﻿using UnityEngine;
using System.Collections;

public class PlayerInputManager : MonoBehaviour {

    public float rotationSpeed = 20f;
    public float moveSpeed = 1;

    private string m_inputMovementAxisName;
    private string m_inputRotationAxisName;

    private float m_inputMovement;
    private float m_inputRotation;

    private Rigidbody m_rigidbody;

    // Use this for initialization
    void Start () {
        Init();
	}

    private void Move()
    {
        m_inputMovement = Input.GetAxis(m_inputMovementAxisName);
        Vector3 movement = transform.forward * m_inputMovement * moveSpeed * Time.deltaTime;

        m_rigidbody.MovePosition(m_rigidbody.position + movement);

    }

    private void Rotate()
    {
        m_inputRotation = Input.GetAxis(m_inputRotationAxisName);

        float turn = m_inputRotation * rotationSpeed;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        m_rigidbody.MoveRotation(m_rigidbody.rotation * turnRotation);
    }

    public void Init()
    {
        m_inputMovementAxisName = "Vertical";
        m_inputRotationAxisName = "Horizontal";

        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        Move();
        Rotate();
    }
}
