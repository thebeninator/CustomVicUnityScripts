using UnityEngine;

namespace CustomVicUnityScripts
{
    public class CVDestructibleComponent : MonoBehaviour
    {
        public string Name;
        public float Health;
        public float DamageThreshold;
        public float PressureTolerance;
        public Collider ComponentCollision;
    }
}
