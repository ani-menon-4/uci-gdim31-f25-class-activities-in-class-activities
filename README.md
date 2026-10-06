# in-class-activities
## Devlogs
### W1
1. Detatching the Camera from the Cat GameObject and running the project causes the Camera to not follow the Cat - when the Cat moves, the Camera will not stay fixed within the Cat's face, but rather will stay in its initial position, floating in the air.
2. https://ani-m.itch.io/ani-m-w1-in-class-activity

### W2
1. The "r", "g", and "b" variables are all declared as Floats because the Color option on the Ball's SpriteRenderer Component will only take RBG values that are Integers or Floats, therefore excluding the String and Boolean from being potential type options. From here, the current RGB system that the SpriteRenderer Color option is set to is "RGB 0-1.0", not "RGB 0-255", which means that the Color option here is intended to take Float values.
2. "_bounces" is declared as a Integer variable because it serves the purpose of an incrementing counter. It would not make sense to have "0.1 bounces", "true bounces", or "'apple' bounces" - hence, all other variable types are not suited to the task of counting bounces, meaning that the "_bounces" variable must be an Integer.
3. The error in Step 4, Part 2 highlighted the end of the statement, indicating that a semicolon was missing there. The code would not compile without a semicolon present at the end of that line.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 