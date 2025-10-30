# Prototype 2: VR Implementation - Physics-Based Interactions & Environmental Control

## Overview

Prototype 2 transitioned from desktop to full VR implementation on Meta Quest headsets, testing physics-based book grabbing, poke-interactive audio controls, and workspace object manipulation. This prototype focused on validating realistic VR interactions within immersive library environments.

## Build Information

Platform: Meta Quest 2/3 (Unity VR)
SDK: Meta XR All-in-One SDK with Interaction Rig
Controls:

- VR Controllers: Hand tracking and button interactions
- Locomotion: Intended controller-based movement (non-functional in testing)
- Grab: Trigger button for physics-based object manipulation
- Poke: Index finger touch interactions


Testing Date: Week 9
Participants: 1 tester (tutor) - recruitment failure due to technical issues

## Prototype Features
**Implemented Interactions**

**1) Physics-Based Book Grabbing**

- Natural reach-and-grab interaction using VR controllers
- Realistic book physics and haptic feedback
- Selection from 3D bookshelves in library environment

**2) Poke-Interactive Audio Control**

- Spatial audio system using Meta Spatial Audio Building Block
- Poke Interactable surface for finger-touch activation
- Unity Event Wrapper connecting interactions to audio playback
- Custom AudioPlayer script (PlayAudio/StopAudio methods)

**3) Workspace Customization (Intended)**

- Garden workspace with grabbable objects (picnic rug, modular tree, basket)
- Scaling interactions for object manipulation
- Spatial arrangement for personalized reading environments
- Status: Untested due to locomotion failure

## Testing Objectives

- Validate VR-native controller interactions for book selection
- Test environmental audio control intuitiveness
- Assess workspace object manipulation and scaling gestures
- Evaluate comfort and spatial understanding in VR

## Key Results

Successful Elements

- Book grabbing: 8.5/10 naturalness - "Exactly what you'd do in real life"
- Task 1 completion: 15 seconds - Fast and intuitive
- Audio control functional - Poke interaction registered successfully
  

## Critical Failures

- VR locomotion non-functional - Could not walk using controllers (only head/hand tracking)
- Workspace customization untested - Movement constraint blocked Task 3
- Participant recruitment: 1 - Technical issues deterred participants
- Direct APK build failed - Required Sidequest workaround

## Qualitative Insights

Interaction feedback gap: User uncertain if audio was playing without visual confirmation
Concept validation: "Can help have better immersive experience... even non-readers would want to try"
Polish needed: "These are basics that can be polished better - continue working on it"

## Assets & Resources

- Meta SDK Building Blocks: Spatial Audio, Poke Interaction
- Custom Scripts: AudioPlayer.cs
- Environment: Library scene + Garden workspace
- Interaction Components: Grabbable objects, poke surfaces

## Critical Issues Encountered

Locomotion System Failure

- Head/hand tracking functional, controller movement non-functional
- Blocked spatial navigation testing
- Required manual player repositioning in Unity

Build Pipeline Problems

- Direct Unity → Meta Quest deployment failed
- Forced Sidequest APK installation workflow
- Added complexity and time overhead


## Next Steps → Prototype 3

- Start fresh scene with verified locomotion system
- Focus on VR-native interactions that exploit impossible physics
- Implement miniaturized library concept (from P1 tutor feedback)
- Add portal-based navigation to avoid locomotion dependency
- 5 participants with confirmed time slots
- Add visual feedback for all interaction states
