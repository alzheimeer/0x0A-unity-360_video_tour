<p align="center">
<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Unity_Technologies_logo.svg/275px-Unity_Technologies_logo.svg.png" alt="drawing" width="300"/>
</p>

# 0x0A. Unity - 360 Video

## What you should learn
At the end of this project you are expected to be able to explain to anyone, without the help of Google:

* What is 3DOF vs 6DOF
* What VR headsets are on the current market and how to target them
* What is 360 video and what are its potential use cases
* What is the difference between monoscopic and stereoscopic 360 video
* What are render textures
* How to use Unity’s Video Player component

## 0. Tour guide
In this project you will be creating a 360 video VR tour

## 1. Spheres of influence 
Create three new Spheres for the remaining videos and name them accordingly.

* ```Cantina```
* ```Cube```
* ```Mezzanine```
You may find that when running or testing your build, your headset or Unity itself may not be able to handle multiple videos or Render Textures at once. Keep videos disabled unless necessary.

## 2. Hotspots 
Inside the ```LivingRoom``` Sphere, create a Button with the provided image to be a hotspot called ```CantinaHotspot``` and a text element with the text “Cantina” next to it.

Create behavior for your hotspot button such that when the user interacts with it via controller or gaze, it will take them to the ```Cantina``` Sphere. Likewise, inside the ```Cantina``` Sphere, create a hotspot called ```LivingRoomHotspot``` that will return the user back to the ```LivingRoom``` Sphere.

## 3. The full tour 
Create hotspots to link the rest of the Spheres together as illustrated in task #0. The user should start in the ```LivingRoom``` and be able to navigate through all four rooms and view the associated 360 video for each. Keep your Hierarchy in mind as you create new GameObjects and organize them accordingly.

## 4. Tell me more
In the ```LivingRoom``` Sphere, create a Button with the provided image that activates an informational text box when the user interacts with it.

## 5. Points of interest 
Create similar text boxes for the remaining Spheres with the following information.
* ```LivingRoom```
* ```Cantina```
* ```Cube```
* ```Mezzanine - 1```
* ```Mezzanine - 2```

## 6. No need for silence
Download the audio file ```“Tech Live” by Kevin MacLeod``` and import it into the project. Make sure your README.md contains ```attribution``` for the audio asset. Add the audio to the project so that it plays throughout the length of the tour and loops if necessary.

## 7. Building tour 
## Scenes in Build:

1. ```360VideoTour```

Create a build of the tour in a ```Builds``` directory and name it based on your targeted device (ex. ```360VideoTour_<TargetHeadsetName>``` -> ```360VideoTour_OculusGo```).

## Build Folder Hierarchy:

* Builds
    * [Target Device]
        * [Associated Build Files]

## Credits: ##

Audio: [“Tech Live”](https://incompetech.filmmusic.io/song/4463-tech-live/) by Kevin MacLeod

## Author

Edgar Quintero  | [https://github.com/alzheimeer](https://github.com/alzheimeer)