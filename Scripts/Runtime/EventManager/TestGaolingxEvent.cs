using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ybh
{
    public class TestGaolingxEvent : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameEventsManager.MainInstance.CallEvent("Test_Event_01");
            }
        }
        private void OnEnable()
        {
            GameEventsManager.MainInstance.AddEventListening("Test_Event_01", SendText);
        }
        private void OnDisable()
        {
            GameEventsManager.MainInstance.ReMoveEvent("Test_Event_01", SendText);
        }
        private void SendText()
        {
            Debug.Log("事件成功被调用");
        }

    }
}
