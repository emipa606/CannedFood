# GitHub Copilot Instructions for Canned Food (Continued)

## Mod Overview and Purpose
Canned Food (Continued) is a RimWorld mod that builds upon the original Canned Food mod created by srauon, further updated by Xsile. The purpose of this mod is to introduce the concept of canned food into the game, providing a means for players to store and preserve food. This mod enhances the gameplay experience by allowing colonists to consume canned food directly or use them as ingredients in other recipes.

## Key Features and Systems
- **Canned Food**: Players can create canned food using meat or vegetables, which are preserved and won't spoil easily.
- **Cans**: Cans can be crafted at the Smithy using steel. Researching Smithing and Canning is required to make cans and canned food.
- **Stackable Graphics**: Canned food items have a stackable graphic type, allowing for efficient storage.
- **Empty Cans**: Consuming canned food or using them in recipes will spawn empty cans.

## Coding Patterns and Conventions
- **C# Files**: The mod consists of four C# files, each with specific responsibilities:
  - `CannedFood.cs`: Contains the logic for post-ingestion effects of canned food.
  - `Main.cs`: The entry point of the mod, where the Harmony patches are applied.
  - `RecipeWorker_ConsumeIngredient.cs`: Handles the prefix for recipe workers to consume ingredients.
  - `ThingDefOf.cs`: Defines custom ThingDefs used in the mod.

- **XML Integration**: The mod uses XML files to define various game entities such as recipes, research projects, and thing definitions. XML files are located in the `Defs` directory and are structured as follows:
  - `RecipeDefs`: Contains definitions for the recipes related to canned food and cans.
  - `ResearchProjectDefs`: Defines research projects required to unlock the creation of canned food and cans.
  - `ThingDefs`: Includes definitions for the canned food and can items.

- **Harmony Patching**: The mod uses Harmony for patching existing RimWorld methods to introduce new behaviors. Key patches include:
  - `PostIngested`: Modifies the post-ingestion effects of canned food.
  - `RecipeWorker_ConsumeIngredient.Prefix`: Customizes the behavior of consuming ingredients in recipes.
  - `TargetMethods`: Defines target methods for Harmony patches.

## Suggestions for Copilot
- **Coding Assistance**: Use Copilot to generate code snippets for new features or improvements to existing methods, such as adding new effects for different types of canned food.
- **XML Defs**: Utilize Copilot to assist in creating new XML definitions for additional recipes or thing types, ensuring proper syntax and structure.
- **Harmony Patches**: Leverage Copilot to help craft Harmony patches for modifying existing game mechanics, making sure to target the correct methods and apply necessary changes.
- **Documentation**: Use Copilot to assist in documenting new code or changes, ensuring that the documentation is clear and comprehensive.

## Contributing Guidelines
- **Coding Standards**: Follow RimWorld coding standards and conventions, ensuring that the code is maintainable and efficient.
- **Testing**: Test new features and changes thoroughly to ensure compatibility and functionality within the game.
- **Feedback**: Provide feedback on Copilot suggestions to improve its accuracy and relevance for RimWorld modding.

By following these guidelines and utilizing Copilot effectively, you can contribute to the development of Canned Food (Continued) and enhance the gameplay experience for RimWorld players.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

