using UnityEngine;

namespace GameDev3Library.Utilities
{
    public class AlwaysFaceCamera : MonoBehaviour
    {
        private void Update()
        {
            transform.rotation = 
                Quaternion.LookRotation( transform.position - Camera.main.transform.position );
        }
    }
}