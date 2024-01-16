# Contributing
Your help is highly valued! Below we discuss a few things that are important to know before contributing.

## Coding style
In this repository we enforce PascalCase. camelCase is used in variables gathered from function arguments. A good example on this may be found below:
```CSharp
namespace DorianEngine.Core
{
    public class Material
    {
        public Vector3 DiffuseColor;
        public float Alpha;
    
        public Material(Vector3 diffuseColor, float alpha)
        {
            DiffuseColor = diffuseColor;
            Alpha = alpha;
        }
    }
}
```

## Way of contributing
We most appreciate contributions directly by forking the repository, making your changes, and then making a pull request.

## Contribution rules
- Comments are not necessary, but preferred if you deem the code difficult to understand to someone else.
- Keep external dependencies/additional libraries to a bare **minimum**.
- Do not make use of the content manager. Everything must be done from stream/from file. No MGCB.

## What to contribute on
Things that need to be worked on, include, but are not limited to:
- Basic physics
	- Rigidbody component
	- Mesh collider component
	- Wheel component
- Editor/Studio
	- Scene tree
	- Properties
	- Solution explorer
	- Lua IDE
	- Scene preview
- Default shader
	- Diffuse
	- Specular
	- Bump mapping
	- Reflections
- Lua scripting
	- Choose external library for Lua
	- Translate C# functions to Lua for scripting
- Audio component
	- Decide if another library or not
	- Volume
	- Speed
	- Paused
	- Looped
	- Hearing range
	- Hearing range fade
- Extended 3D model format
	- FBX? 3DS? DirectX? Needs animation support

It’s important to note that the topics mentioned are not the only that need to be worked on. Approved feature requests are also things that need to be worked on.
