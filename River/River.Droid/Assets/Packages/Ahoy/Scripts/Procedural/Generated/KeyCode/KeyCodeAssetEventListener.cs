//
//
//	THS FILE IS AUTO GENERATED
//	DO NOT EDIT DIRECTLY
//
/*AUTO SCRIPT*/using UnityEngine;
/*AUTO SCRIPT*/using UnityEngine.Events;
/*AUTO SCRIPT*/using System.Collections.Generic;
/*AUTO SCRIPT*/using System;
/*AUTO SCRIPT*/using System.Linq;
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/namespace Ahoy
/*AUTO SCRIPT*/{
/*AUTO SCRIPT*/    public class KeyCodeAssetEventListener : MonoBehaviour
/*AUTO SCRIPT*/    {
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/        public KeyCodeAssetEvent assetEvent;
/*AUTO SCRIPT*/        public KeyCodeUnityEvent response;
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/        private void OnEnable()
/*AUTO SCRIPT*/        {
/*AUTO SCRIPT*/            assetEvent.AddListener(response);
/*AUTO SCRIPT*/        }
/*AUTO SCRIPT*/        private void OnDisable()
/*AUTO SCRIPT*/        {
/*AUTO SCRIPT*/            assetEvent.RemoveListener(response);
/*AUTO SCRIPT*/        }
/*AUTO SCRIPT*/    }
/*AUTO SCRIPT*/}