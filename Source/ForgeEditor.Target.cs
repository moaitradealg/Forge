using UnrealBuildTool;
using System.Collections.Generic;

public class ForgeEditorTarget : TargetRules
{
	public ForgeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;

		ExtraModuleNames.AddRange( new string[] { "Forge" } );
	}
}
