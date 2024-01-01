using UnrealBuildTool;

public class ThePact_DMXTarget : TargetRules
{
	public ThePact_DMXTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ThePact_DMX");
	}
}
