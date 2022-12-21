using UnityEngine;

namespace Game.Scripts
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;
        [SerializeField] private float distance;

        private void LateUpdate()
        {
            if (playerTransform == null)
                return;

            Vector3 followingPosition = new Vector3(0, 0, -distance) + playerTransform.position;

            transform.position = followingPosition;
        }
        
    }
}