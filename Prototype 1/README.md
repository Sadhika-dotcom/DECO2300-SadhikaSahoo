# Prototype 1: Horizontal Prototype - Spatial Navigation & Book Selection

## Overview
Prototype 1 established the foundational spatial navigation and book selection interactions for the XR Kindle reading experience. This horizontal prototype tested basic 3D library navigation, book discovery, and selection mechanics in a desktop environment before full VR implementation.

## Build Information

Platform: Unity Desktop (Mouse & Keyboard)
Controls:
- WASD: Player movement
- Mouse: Camera look/aim
- E Key: Book selection (raycast-based)


Testing Date: Week 5
Participants: 5 testers (including course tutor)

## Prototype Features
**Implemented Interactions**

**1) 3D Library Navigation**

- First-person movement through virtual library space
- Multiple bookshelves with spatial organization
- Raycast selection system for book interaction


**2) Book Selection Mechanic**

- Target: Bookrow > Bookcase 2 > Bookshelf 2 middle
- E key to grab selected book
- Visual feedback for selectable objects


**3) Environment Preview**

- Garden workspace scene (non-interactive)
- Environmental UI elements for future functionality
- Transition between library and workspace areas



## Testing Objectives

- Validate spatial wayfinding in 3D library environments
- Test book selection interaction clarity
- Assess user understanding of spatial layout
- Gather feedback on immersive reading environment concept

Key Results

- 100% task completion rate - all participants successfully navigated and selected books
- Average completion time: 15 seconds (67% faster than 45-second target)
- High intuitiveness ratings: 8.5/10 from experienced users
- Strong concept validation: "Very fascinating and cool... even non-readers would be interested"

## Critical Feedback

- Camera height issue: Player perspective appeared too low, creating "crawling" sensation
- Collision detection needed: Lack of colliders allowed unrealistic movement through objects
- Book management workflow: Need dual-access system (library exploration + workspace book panel)
- VR capability challenge: Tutor feedback to "not limit ourselves" and explore VR-specific interactions

## Technical Assets Used
**External Resources**

- Textures: Bush, ball, rug, grass (sourced from Pinterest, Freepik, iStock)
- Wood texture: YughuesFreeFlooringMaterials (Unity Asset Store)
- Furniture: ZNS3D Mix_Furniture_Pack (Unity Asset Store)
- Books: 3dobjects_BX with textures and prefabs (Unity Asset Store)

## Custom Content

- Self-designed materials for furniture and walls
- Custom prefab sets combining furniture assets
- Original scene layout and spatial design

## Scripts

From Course GitHub: DebugRotator, Mover, Rotator

External tutorials:

- PlayerMovement (Brogammer YouTube)
- PickUpBlock (Gunzz YouTube)

## Lessons Learned

- Desktop testing validates spatial concepts before VR complexity
- Realistic interactions feel immediately intuitive but may limit VR potential
- User expectations include environmental interaction beyond primary tasks
- Camera positioning critical for immersion and comfort

## Next Steps → Prototype 2

- Implement full VR with Meta Quest support
- Add physics-based grabbing interactions
- Develop environmental audio controls
- Create interactive workspace customization
- Address camera height and collision detection
