using UnrealBuildTool;
using System.Collections.Generic;

public class ForgeTarget : TargetRules
{
	public ForgeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;

		ExtraModuleNames.AddRange( new string[] { "Forge" } );
	}
}
