// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class DragonBonesEditorPlugin : ModuleRules
	{
		public DragonBonesEditorPlugin(ReadOnlyTargetRules Target) : base(Target)
		{
			PublicIncludePaths.AddRange(new string[] { "DragonBonesEditorPlugin/Public", "DragonBonesPlugin/Public/DragonBonesCPP" });
            
            PrivateIncludePaths.AddRange(new string[] { "DragonBonesEditorPlugin/Private", "DragonBonesPlugin/Public/DragonBonesCPP" });
            
            PublicDependencyModuleNames.AddRange(new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "UnrealEd",
                "DragonBonesPlugin"
            });
            
            PublicIncludePathModuleNames.AddRange(new string[] {
               "AssetTools",
               "AssetRegistry"
            });
            
            DynamicallyLoadedModuleNames.AddRange(new string[] {
               "AssetTools",
               "AssetRegistry"
            });
		}
	}
}
