using UnityEngine;

namespace InputSystem
{
    public class InputListner : MonoBehaviour
    {
        private void Update()
        {
            ReadjumpInput();
        }

        private void ReadjumpInput()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                //
            }
        }
    }
}