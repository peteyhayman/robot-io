//
//
//	THS FILE IS AUTO GENERATED
//	DO NOT EDIT DIRECTLY
//
/*AUTO SCRIPT*/using Unity.Entities;
/*AUTO SCRIPT*/using UnityEngine;
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/namespace Ahoy.Net
/*AUTO SCRIPT*/{
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/    // [CreateAssetMenu(fileName = "SendPose", menuName = "Ahoy.Net/Message Sender/Pose", order = 0)]
/*AUTO SCRIPT*/    public class PoseArrayMessageSender : MessageSender<Pose[]>
/*AUTO SCRIPT*/    {
/*AUTO SCRIPT*/        protected override byte[] GetBytes(Pose[] val)
/*AUTO SCRIPT*/        {
/*AUTO SCRIPT*/            return PoseParse.EncodeToBytes(headerInfo.channel, headerInfo.command, val);
/*AUTO SCRIPT*/        }
/*AUTO SCRIPT*/    }
/*AUTO SCRIPT*/
/*AUTO SCRIPT*/}