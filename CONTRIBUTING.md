# Contributing to the development of the engine
Your contribution is highly valued! Below I will discuss several things that will need to be implemented and how you may contribute. I will also provide my roadmap/planned list of features.

## How to contribute
Contribution is most appreciated thru a fork, and then a pull request. **Please maintain a clear and understandable coding style**, the style is best summarized by MonoGame's `Game1.cs` style. <u>Avoid hardcoding at all costs!</u>

**Give variables meaningful names**. Publicly accessed variables are always `UppercaseAnotherUppercase`. Variables used in privates or functions are always `lowercaseAndNowUppercase`. If deemed necessary, a function variable may have a `_thatsAnUnderscore`.

**Comments on more advanced/technical code are preferred, but not a requirement**. I do request a clear explanation of your changes and how they contribute to the engine.

Nested if's are preferred over any other workaround you might have in mind.

<u>**Note:**</u> Pull requests that are deemed "stupid", not well-thought-out, or containing leftover mess may be denied.

## What is to be done and roadmap
The roadmap is sorted into `PLANNED`, `IN PROGRESS`, `TO BE IMPLEMENTED` and `DONE`. The first one is for planned content, the second for things that I'm currently focusing/working on, the third for things that code structure exists for but do not have implemented functionality and the latter for things that are done/implemented.

- Rendering
  - Generalised lighting: **IN PROGRESS**
  - 3D Rendering: **IN PROGRESS**
  - GUI Rendering: **IN PROGRESS**
  - Custom shaders: **PLANNED**
- Technical systems
  - ECS base: **DONE**
  - Scene management: **DONE**
  - Update system: **TO BE IMPLEMENTED**
  - Lua scripting: **PLANNED**
- Physics
  - Rigidbody physics: **PLANNED**
  - Mesh collision: **PLANNED**
  - Wheel component: **PLANNED**