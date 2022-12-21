using UnityEngine;

namespace Game.Scripts
{
    
    public class InputService : MonoBehaviour
    {
        [SerializeField] private WheelMove wheelMove;
        public Vector3 mousePos;

        private void Update()
        {
            CheckMousePosition();
            CheckSide();
        }

        private void CheckMousePosition()
        {
            if (Input.GetMouseButton(0))
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition)  - transform.position;
            }
        }

        private void CheckSide()
        {
            if (mousePos.x > 0)
            {
                wheelMove.movingRight = true;
            }
            else
            {
                wheelMove.movingRight = false;
            }
        }
    }
}