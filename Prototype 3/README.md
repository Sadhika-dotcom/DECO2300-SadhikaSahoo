# Prototype 3: VR-Native Interactions - Miniature Library & Portal Teleportation

## Overview

Prototype 3 represents a complete redesign focused on VR-native interactions that exploit impossible physics unavailable in real-world contexts. Moving beyond realistic simulation, this prototype tests miniaturized portable libraries, dynamic book scaling, and portal-based environment teleportation - interactions uniquely possible in VR.

## Build Information

Platform: Meta Quest 2/3 (Unity VR - Fresh Scene)

SDK: Meta XR All-in-One SDK with verified locomotion

Controls:

- VR Controllers: Controller-based smooth locomotion (functional)

- Grab: Trigger button with distance grabbing

- Scale: Pinch gesture (dual-controller pull/push)

- Portal: Physics-based cube placement

Testing Date: Week 12

Participants: 5 testers (successful recruitment)

## Prototype Features

Implemented Interactions

**1) Miniaturized Pocket Library**

- Entire book collection condensed to desk-size display - "Cute mini books" (P3) visible simultaneously

- Eliminates spatial navigation requirements - Inspired by P1 tutor feedback: "pocket library you can pull out"

- Dynamic Book Scaling

- Grab miniature book from collection

- Pinch-zoom gesture (familiar from smartphones) scales to readable size

- Supports scaling to any size - "extend to room size and read while walking on book" (P3)

- Leverages transferable mental model from touch interfaces
  

**2) Portal Teleportation System**

- PortalCore: Interactive green cube with text label

- PortalDock: Pink teleportation pad platform with text label

- Interaction: Grab cube → Place on dock → Teleport to forest reading environment

- Bidirectional: Same system returns user to library

- Avoids locomotion-induced motion sickness (though transition speed caused issue for 1 participant)
  

**3) Immersive Reading Environments**

- Library Scene: Study space with mini library, desk, furniture, guitar (ambient)

- Forest Scene: Zen garden with trees, benches, table, coffee mug

- Text labels for discoverability: "Mini Library", "PortalDock", "PortalCore"

## Testing Objectives

- Test intuitiveness of VR-native spatial manipulation (miniaturization, scaling)

- Validate portal-based scene transition effectiveness

- Compare VR-native approach vs. realistic simulation (Prototype 2)

- Assess whether impossible physics feel natural with proper mental model grounding


## Critical Findings

Validated Design Decisions

- Mini library highly intuitive - "Cute mini books... I would treat it as my sanctuary" (P3)

- Smartphone gesture transfer works - Pinch-zoom felt immediately natural (P2: "same as smartphone")

- Immersive environments valued - "Teleport to different room... fun because you can't do that in real world" (P4)

- Text labels supported comprehension - 80% found very helpful

## Critical Design Gaps

- Book-world conceptual disconnect - Users expected thematic connection (P1: "Separate objects was too much")

- Portal interaction not self-evident - Required text labels despite metaphor (P5: "Not intuitive without guidance")

- Book opening expectation unmet - 80% tried/wanted to open books (P1, P3, P4, P5)

- Grab distance limitation - P4: "Can only grab when really close slowed me down"

## Notable Quotes

- P3: "I can extend size to the room and read while walking on the book... I would genuinely enjoy it"

- P1: "Having desk, cube, and book as separate objects was too much disconnect"

- P2: "Instead of dropping cube, more natural if you just walk in [to teleportation pad]"

- P5: "Teleportation did not feel connected - suddenly teleported to different place"

## Technical Assets

**Custom Implementation**

- Fresh scene design with study space + forest environments

- Mini library spatial arrangement (3 miniature bookshelves on desk)

- Portal system with physics-based cube-dock interaction

- Text label UI elements for affordance

## External Resources

- Meta SDK: Spatial audio, interaction rig, locomotion system

- Unity assets: Environmental furniture, trees, props

- Custom scripts: Object scaling, portal teleportation trigger


Research Foundation

This prototype was grounded in academic research:

- Zhang et al. (2022): Spatial scale manipulation enhances perception and engagement

- Bowman & McMahan (2007): Portal-based navigation reduces motion sickness vs. smooth locomotion

- Dourish (2001): Tangible interactions create stronger mental models

## Lessons Learned
What Worked

- Miniaturization concept resonated emotionally - Personal library sanctuary

- Familiar gestures enable VR-native interactions - Smartphone pinch-zoom → book scaling

- Mixed-methods data collection effective - Think-aloud + interview + survey captured depth


## Design Evolution Insight

The journey from realistic simulation (P2) to VR-native (P3) revealed that the answer is hybrid: users want familiar book interactions (grabbing, opening) within impossible spatial contexts (miniaturization, instant environment switching). Pure VR-native interactions lack grounding; pure realistic simulations miss VR's potential.

## Future Directions

Immediate Improvements

- Integrate book-world system - Opening book reveals/transports to thematic environment

- Add raycast grab - Distance selection reduces navigation friction

- Implement book opening gesture - Dual-controller pull gesture satisfies 80% user expectation

- Configurable teleportation - Speed/transition style options for accessibility

## Extended Concept

- AR Hybrid Mode - Detect physical books, overlay digital annotations, preview VR environments

- Persistent Mini Library - Meta Scene API spatial anchor for "always-available" reading access

- Thematic World Library - Each book linked to environment matching its content (mystery → mysterious forest)


