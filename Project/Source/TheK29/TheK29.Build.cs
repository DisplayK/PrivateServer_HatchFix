using UnrealBuildTool;

public class TheK29 : ModuleRules {
	public TheK29(ReadOnlyTargetRules Target) : base(Target) {
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bLegacyPublicIncludePaths = false;
		ShadowVariableWarningLevel = WarningLevel.Warning;

		PublicDependencyModuleNames.AddRange(new string[] {
			"AIModule",
			"Activation",
			"AkAudio",
			"AnimationBudgetAllocator",
			"AnimationUtilities",
			"CinematicCamera",
			"Competence",
			"Core",
			"CoreUObject",
			"CoreUtilities",
			"Customization",
			"DBDAnimation",
			"DBDAnimationBudgetAllocator",
			"DBDAttack",
			"DBDAudio",
			"DBDBots",
			"DBDCompetence",
			"DBDCosmetic",
			"DBDGameplay",
			"DBDInput",
			"DBDInteraction",
			"DBDSharedTypes",
			"DBDUIViewInterfaces",
			"DBDUIViewsMobile",
			"DataTableUtilities",
			"DeadByDaylight",
			"Engine",
			"Foliage",
			"GFXUtilities",
			"GameSessionDS",
			"GameflowNotifications",
			"GameplayTagUtilities",
			"GameplayTags",
			"GameplayUtilities",
			"InputCore",
			"InputUtilities",
			"Interaction",
			"LevelSequence",
			"MediaAssets",
			"MovieScene",
			"NavigationSystem",
			"NetworkUtilities",
			"Niagara",
			"OnlineMessagesUtilities",
			"OnlinePresence",
			"OnlineSubsystemUtils",
			"OnlineTransactions",
			"Paper2D",
			"Penalty",
			"PhysicsCore",
			"PhysicsUtilities",
			"PlatformsProviders",
			"Projectile",
			"QueryService",
			"ReversibleActionSystem",
			"RewardUtilities",
			"ScaleformUI",
			"SharedAuthenticationUtilities",
			"SignificanceUtilities",
			"Slate",
			"SlateCore",
			"SocialParty",
			"StatSystem",
			"SystemUtilities",
			"TheDemogorgon",
			"TimeUtilities",
			"Toasts",
			"UMG",
			"VFXUtilities",
		});
	}
}
