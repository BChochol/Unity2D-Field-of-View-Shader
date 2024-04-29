# Field of View shaders for Unity2D with URP
Project consist of sample assets and two main shaders, both based on ShadowCaster2D system and Default-Lit-Shader provided in URP. However, both shaders are intependent of 2D Lighting, which means they can both cover player's vision and cast shadows from light on scene.
I achieved this effect by adding new blend style to URP's settings and assigning it to a 2D Light plugged to player. This way, player's field of view acts as a 2D Light and has all settings that a 2D Light would have, but it doesn't illuminate anything. Instead, it greys out everything that is outside player's vision. Additionally, objects that have material with "Covered" shader become invisible when not in the range of the vision. The field of view is obstructed by objects with ShadowCaster2D.
The player is casting shadow from local light objects on scene but the shadow have no affect on player's vision, as it was intended, those two systems are independent.

![Visible](https://github.com/BChochol/Unity2D-Field-of-View-Shader/assets/57318832/c81d847a-6b89-4bc4-b8c0-0f2c1a22762e)
![Ivisible1](https://github.com/BChochol/Unity2D-Field-of-View-Shader/assets/57318832/cd98a170-1e61-46a6-921f-883772c3758c)
![Invisible3](https://github.com/BChochol/Unity2D-Field-of-View-Shader/assets/57318832/bca50e10-86d9-441e-afe1-343acd94dba3)
![Invisible2](https://github.com/BChochol/Unity2D-Field-of-View-Shader/assets/57318832/4448e7bd-89dc-4d8f-822e-23a0b59b43ce)
