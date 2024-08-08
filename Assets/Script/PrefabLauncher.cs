using System;
using UnityEngine;

namespace Samarnggoon.GameDev3.Chapter4
{
    public class PrefabLauncher : MonoBehaviour
    {
        [SerializeField] protected float m_Interval = 1.2f;
        [SerializeField] protected GameObject m_PrefabToBeLaunched;
        [SerializeField] protected float m_Power = 10;

        private void Start()
        {
            Invoke(nameof(LaunchPrefab), 0);
        }

        protected void LaunchPrefab()
        {
            var g = Instantiate(m_PrefabToBeLaunched);
            g.transform.position = transform.position;
            var rb = g.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * m_Power, ForceMode.Impulse);
            Destroy(g, 3);
            Invoke(nameof(LaunchPrefab), m_Interval);
        }
    }
}   
