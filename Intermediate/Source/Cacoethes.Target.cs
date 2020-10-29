using UnrealBuildTool;

public class CacoethesTarget : TargetRules
{
	public CacoethesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Cacoethes");
	}
}
