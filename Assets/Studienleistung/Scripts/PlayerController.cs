using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private int m_healthPoint;
    private Transform m_spawnPoint;
    private PlayerInputManager m_inputController;

    public int HealthPoint
    {
        get
        {
            return m_healthPoint;
        }

        set
        {
            m_healthPoint = value;
        }
    }

    public void Init(Transform m_spawnPoint)
    {
        // Referenzen
        this.m_spawnPoint = m_spawnPoint;

        // Ressourcen
        m_healthPoint = 100;

        // Input
        m_inputController = GetComponent<PlayerInputManager>();
        m_inputController.Init();
    }

}
