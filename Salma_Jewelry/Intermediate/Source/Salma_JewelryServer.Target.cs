using UnrealBuildTool;

public class Salma_JewelryServerTarget : TargetRules
{
	public Salma_JewelryServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Salma_Jewelry");
	}
}
