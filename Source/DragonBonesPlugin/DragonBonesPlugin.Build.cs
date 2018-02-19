// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class DragonBonesPlugin : ModuleRules
	{
		public DragonBonesPlugin(ReadOnlyTargetRules Target) : base(Target)
		{
			PublicIncludePaths.AddRange(new string[] { "DragonBonesPlugin/Public", "DragonBonesPlugin/Public/DragonBonesCpp" });
            PrivateIncludePaths.AddRange(new string[] { "DragonBonesPlugin/Private", "DragonBonesPlugin/Public/DragonBonesCpp" });
            PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "RHI", "RenderCore", "ShaderCore", "ProceduralMeshComponent", "RuntimeMeshComponent" });
            OptimizeCode = CodeOptimization.Never;
		}
	}
}
