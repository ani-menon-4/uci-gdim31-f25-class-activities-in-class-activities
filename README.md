# in-class-activities
## Devlogs
### W1
1. Detatching the Camera from the Cat GameObject and running the project causes the Camera to not follow the Cat - when the Cat moves, the Camera will not stay fixed within the Cat's face, but rather will stay in its initial position, floating in the air.
2. https://ani-m.itch.io/ani-m-w1-in-class-activity

### W2
1. The "r", "g", and "b" variables are all declared as Floats because the Color option on the Ball's SpriteRenderer Component will only take RBG values that are Integers or Floats, therefore excluding the String and Boolean from being potential type options. From here, the current RGB system that the SpriteRenderer Color option is set to is "RGB 0-1.0", not "RGB 0-255", which means that the Color option here is intended to take Float values.
2. "_bounces" is declared as a Integer variable because it serves the purpose of an incrementing counter. It would not make sense to have "0.1 bounces", "true bounces", or "'apple' bounces" - hence, all other variable types are not suited to the task of counting bounces, meaning that the "_bounces" variable must be an Integer.
3. The error in Step 4, Part 2 highlighted the end of the statement, indicating that a semicolon was missing there. The code would not compile without a semicolon present at the end of that line.

### W3
#### Activity 1: Methods Discussion (Table )
1. The parameters should be an Integer representing the player's dialogue choice (so 1 for the first choice, 2 for the second choice, and so on for however many choices there are), an Integer representing the player's current friendship level, and a Boolean representing whether the character secret was discovered. The return type should probably be a String representing the character's text response, but it could also be an Integer representing the appropriate response (ordered in a similar manner to the Integer for the player dialogue choice), as that could be given to another method responsible for finding and typing that response on screen.
2. This method's parameter should either be an Integer that will only range from 0-100 or a Float that will only range from 0-1 depending on personal discretion, though Float is probably more ideal. As there is not an output, the return type should likely be defined as Void.
3. The parameter should be a Float representing the exact time in which they pressed a key, as this variable needs to be a numerical value and more specific than an Integer. Depending on how specific this game will be with its ratings, the return type should either be a Boolean that signifies whether or not the time was within acceptable bounds to count as on-beat, or a String that returns the rating type ("Miss", "Poor", "Good", "Perfect", etc).

#### Activity 2: Components & Classes Metaphor (Table )
- The Class operates as a general design, or blueprint, that the Component will follow, where methods and member variables indicate specifications on the blueprint that may be modified in order to create a different type of the initial design.

#### Activity 3: Devlog Question
1. 

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 