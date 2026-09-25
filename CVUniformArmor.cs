using UnityEngine;

namespace CustomVicUnityScripts
{
    public class CVUniformArmor : MonoBehaviour
    {
        public string Name;
        public float PrimarySabotRha;
        public float PrimaryHeatRha;
        public float SecondarySabotRha;
        public float SecondaryHeatRha;
        public bool ThicknessListedIsActual = false;
        public bool NoImpactDecals;
        public bool AngleMatters = true;
        public bool NormalizesHits = true;
        public bool CanShatterLongRods = true;
        public bool CanRicochet = true;
        public float CrushThicknessModifier = 1f;
        public float MaxSpallAngleKe = 60f;
        public float MaxSpallAngleCe = 90f;
        public string ArmorCodexId;
    }
}
