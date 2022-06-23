using MQTTnet.Packets;

namespace MQTTnet.Extensions.ManagedClient
{
    public sealed class ManagedMqttSubscription
    {
        public MqttTopicFilter TopicFilter { get; set; }
        
        public bool IsSubscribePending { get; set; }
        
        public bool IsUnsubscribePending { get; set; }
    }
}