// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MG2 : ModuleRules
{
	public MG2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
