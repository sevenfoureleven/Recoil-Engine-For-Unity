# RECOIL ENGINE FOR UNITY

![](ShowcaseVideosPhotos/recoilenginelogo.png)

## Recoil Engine is a procedural recoil system namespace for the Unity game engine.

# SHOWCASE
## Recoil Engine working in my own project with my gun system. (Some aspects, such as returning the weapon from the recoil itself are handled within the weapon system, not Recoil Engine)
[](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/e20f96e8-4ceb-49ba-adcc-11b86f73ccf7)

# SCRIPT EXAMPLE
## Basic example script on how to set-up Recoil Engine in a script.
https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/697625d6-6e55-4bbd-9950-fc45ce994c1f

# INSTALLATION
## How to install Recoil Engine.

### 1. Find the releases page. Click on the available one.
![installationtip1](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/330c41d7-da0d-4950-8b12-db0426c25687)

### 2. Install the .unitypackage file.
![installtip2](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/44cf416c-e707-486c-962b-faa7109188de)

### 3. Drop the .unitypackage into your Unity project and press import. In case you already know how to use Recoil Engine, you can remove the Editor script, as it just has a link to this Github page.
![installtip3](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/f2e66368-bafa-4239-8878-423a32ca88f9)

# DOCUMENTATION
## How to use the RecoilEngineVariables namespace.

### 1. Call the RecoilEngineVariables namespace;
![usingrev](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/54af8fa8-8f85-4446-94a0-bebb7e85579b)

### 2. Define a new RecoilEngine in start. Publicly declaring this is not a valid execution and may cause issues.
![revdefre](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/3cb6c561-dfb2-4743-a126-40c84af440e5)

### 3. Create either a SerializeField or a public RecoilPattern. 
![defrecoilpattern](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/66b33b95-60ad-4236-820d-88c4593d75b9)

### 3.5. You can now access these variables in your object
### Recoil Object: the object the recoil will be applied to. Should be an empty parent object set at 0, 0, 0 rotation for best execution!
### Curve: the animation curve which defines the recoil.
### max Intensity: the absolutely maximum intensity of randomizatiom.
### Max Z Rotation: the maximum rotation on the Z axis.
### Kickback Intensity: how big kickback is, I.e. how much the object will be moved backwards upon recoil. Probably shouldn't be set to over 0.1 in most cases.
### Z Rotation: if you want the object to also rotate on the Z axis.
![revpublicvar](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/a2176f6b-eb2b-4d5e-b48e-9536dff4210a)

### 4. You can now call [recoilenginename].ApplyRecoil(recoilpatternname) in any function.
![revapplyrec](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/d686515a-974b-4fcc-bd0e-b6b3716cbdaa)

### 5. You can also call [recoilenginename].ApplyRandomization(ref recoilpatternname) in any function to randomize the animation curve every time the recoil is called.
![revapplyrandom](https://github.com/TheToolmansCoffee/RecoilEngineVariables/assets/93699568/f3302f13-c30b-47f7-a332-4463afc926e9)
