using UnrealBuildTool;

public class Salma_JewelryEditorTarget : TargetRules
{
	public Salma_JewelryEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Salma_Jewelry");
	}
}
