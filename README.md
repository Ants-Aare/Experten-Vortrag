# Experten-Vortrag


## Start Projekt für die Präsentation
- [Google Slides](https://docs.google.com/presentation/d/17GS75yxhvoBnOk3q0hFaFcFrZN1LH4inp03jT5BniGs)
- [Slido](https://app.sli.do/event/9gUbsTn26mBeAcNy3ufEm3)


## Project Requirements:
- Unity 2021.3.15f1
- C# IDE
- Git
- Your undivided Attention

## Unity test exercise:
The task is to develop a small game: the player navigates his character in a limited area and has to activate switches.
After some time enemies are spawning and shoot with projectiles at the player to hinder him to complete the level.
Please use C# as the coding language and Unity.

### Level UI
The player should see his health points at all times

### Level
- The level itself consists of a plane larger than the camera frustum
- There are switches distributed inside the level area which the player has to touch to activate
- On activation the block changes its color
- As soon as all blocks are activated by the player, the level is completed

### Enemies
- While the player is in the level, enemies are spawning in random intervals
- The enemies won't move, but will shoot projectiles into the players direction
- The player has 5 hit points and each hit of a projectile reduces them by one
- When the player reaches zero hit points a game over screen is shown

### Others
- Implementation should focus on code style, performance and memory usage
- Comments may be used to hint to improvements
- All objects can be created from primitives
