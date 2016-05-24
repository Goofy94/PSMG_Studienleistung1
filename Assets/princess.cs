using UnityEngine;
using System.Collections;

public class princess : MonoBehaviour {
    private string m_inputRotationAxisName;
    private Rigidbody m_princess;
    private float m_inputRotation;
    public float rotationSpeed = 100f;

    // Use this for initialization
    void Start () {
        m_inputRotationAxisName = "Horizontal";
        m_princess = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Rotate();
	}

    private void Rotate()
    {
        m_inputRotation = Input.GetAxis(m_inputRotationAxisName);

        float turn = m_inputRotation * rotationSpeed;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        m_princess.MoveRotation(m_princess.rotation * turnRotation);
    }
}
