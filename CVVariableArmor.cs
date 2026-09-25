using UnityEngine;

namespace CustomVicUnityScripts
{
    public class CVVariableArmor : MonoBehaviour
    {
        public string Name;
        public bool NoImpactDecals;
        public bool AngleMatters = true;
        public bool NormalizesHits = true;
        public bool CanShatterLongRods = true;
        public bool CanRicochet = true;
        public float CrushThicknessModifier = 1f;
        public float MaxSpallAngleKe = 60f;
        public float MaxSpallAngleCe = 90f;
        public float SpallForwardRatio = 0.9f;
        public string ArmorCodexId;
    }
}
