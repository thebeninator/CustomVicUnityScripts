using UnityEngine;

namespace CustomVicUnityScripts
{
    public enum CVAarVisualRenderMode
    {
        HighlightedOnly,
        XrayOnly,
        Always
    }

    public enum CVGenericAarMat
    {
        Generic,
        HE,
        HEAT,
        APFSDS,
        APHE,
        ATGM,
        Flammable,
        Crew
    }

    public class CVAarVisual : MonoBehaviour
    {
        public bool SwitchMaterials;
        public bool PreserveLayerUntilAar;
        public CVAarVisualRenderMode RenderMode;
        public bool HideUntilAar;
        public Material AarMaterial;
        public bool UseGenericMaterial;
        public CVGenericAarMat GenericMaterial;
    }
}
