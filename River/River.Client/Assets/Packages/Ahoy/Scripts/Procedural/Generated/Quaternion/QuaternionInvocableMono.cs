//
//
//	THS FILE IS AUTO GENERATED
//	DO NOT EDIT DIRECTLY
//
/*AUTO SCRIPT*/using UnityEngine;
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/namespace Ahoy
/*AUTO SCRIPT*/{
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/    public class QuaternionInvocableMono : InvocableMono
/*AUTO SCRIPT*/    {
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/        public Quaternion value;
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/        public QuaternionUnityEvent onInvoke;
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/        public override void Invoke()
/*AUTO SCRIPT*/        {
/*AUTO SCRIPT*/            onInvoke.Invoke(value);
/*AUTO SCRIPT*/        }
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/    }
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/}