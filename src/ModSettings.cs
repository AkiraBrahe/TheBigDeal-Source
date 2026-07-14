namespace TBD
{
    public enum SaveCompressionMode
    {
        Normal = 0,
        Reduced = 1,
        Disabled = 2
    }

    public class ModSettings
    {
        public EasyModeSettings EasyMode { get; set; } = new EasyModeSettings();
        public int ExternalHeatPerActivationCap { get; set; } = 1500;
        public bool ScaleObjectiveBuildingStructure { get; set; } = false;
        public SaveCompressionMode SaveCompressionMode { get; set; } = SaveCompressionMode.Disabled;
    }

    public class EasyModeSettings
    {
        public bool AdditionalPlayerMechs { get; set; } = false;
        public bool SaveBetweenConsecutiveDrops { get; set; } = false;
    }
}