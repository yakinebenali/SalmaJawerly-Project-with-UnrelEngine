using UnrealBuildTool;

public class Salma_JewelryTarget : TargetRules
{
	public Salma_JewelryTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Salma_Jewelry");
	}
}
