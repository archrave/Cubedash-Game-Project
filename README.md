The premise of this game - The player object moves forward automatically, the player has to strafe left and right in order to avoid  any obstacles in the way to complete a level.
This project consists of a player object, a few static obstacles, an invisible object to check when the player has completed a level. If the player collides with any of the obstacles, the level restarts. If the player collides with the invisible object at the end of each level, the level ends.

Scripts and their functions:

1. AddCollision.cs - Checks if the player object collides with any of the obstacles, if so, the level is declared as failed.

2. MOVEMENT.cs - Adds force to the player object in the front direction. Adds force towards left or right if the keys 'A' or 'D' are pressed.

3. Startgame.cs - Starts the first level

4. NEXTLVL.cs - If the current level is completed, switches to next level

5. Credits.cs - Exits the game when the "Exit" button on the credit screen is pressed.

6. Restartgame.cs - Checks whether the level is completed or failed, then restarts/shifts to the next level accordingly.

7. UpdateScore.cs - Increases the score of the player as the player proceeds further. The increment is distance based.

8. Followplayer.cs - Moves the camera along with the player, dynamic in only one direction.

All the scripts for this game are in the folder in HelloGithub101/Assets/AllScripts.
All the scripts are coded in C#.
