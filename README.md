This week I worked on connecting the player, coconut, and factory. The main focus of this activity was to practice using a singleton to track coconuts and a factory to spawn new ones. I was able to make the player move, jump, and collect coconuts. The singleton counts them, and the factory makes new ones appear at the respawn point. What I wasn’t able to finish in the 20 minutes was adding the win condition and player states. Even after about 30 minutes it still wasn’t fully done with all the requirements.

Troubleshooting tips: Sometimes the prefab wasn’t spawning right, so double check the prefab is linked in the inspector.

Improvements I can make in the future: Plan ahead and try to complete all requiremnts making it simple ass possible

What was different from last week: Last week I didn't really get much of the project working but this weekweek I built on that by adding the singleton and factory system so coconuts could be tracked and respawned.

Player script
  move with input
  jump if grounded

Coconut script
  if player touches coconut
    add 1 to coconut count in Singleton
    tell factory to spawn new coconut at respawn point
    destroy this coconut

CoconutFactory script
  make a new coconut at given position

Singleton script
  keeps track of coconut count across game
