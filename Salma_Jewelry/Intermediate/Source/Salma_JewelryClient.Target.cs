using UnrealBuildTool;

public class Salma_JewelryClientTarget : TargetRules
{
	public Salma_JewelryClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Salma_Jewelry");
	}
}
