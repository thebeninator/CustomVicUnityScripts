using UnityEngine;

namespace CustomVicUnityScripts
{
    public class CVFlammableItem : MonoBehaviour
    {
        public bool Explosive;
        public float TntEquivalent;
        public bool SelfOxidizing;
        public float FlameHeightMetres;
        public float IgnitionTempMin;
        public float IgnitionTempMax;
        public float IgnitionOverpressureBar;
        public float ShortestBurnTime;
        public float BurnTemperature;
        public float HeatTransferRatio;
    }
}
