# 🎨 BattleBucks – Technical Artist Assignment
 
## Overview
 
This project is a visual enhancement of a basic Unity car prototype, transformed into a polished, arcade-style experience inspired by **Dashy Crashy**. The focus was on stylized visuals, performant VFX, and maintaining a stable **60 FPS on low-end/mobile devices**.
 
---
 
## 🖼️ Approach
 
The visual target was a **Dashy Crashy-like** style — bright, vibrant, high-key lit, and arcade-feeling. Every decision was made to serve this direction while keeping performance in check.
 
---
 
## ✅ What Was Done
 
### 🌆 Environment & Scene
- Stylized environment with background props
- Environment prop textures combined into a **texture atlas**
### 💡 Lighting
- **Local Adaptive Probe Volume (APV)** used for GI coverage
### 🚗 Car Enhancements
- Stylized car material with strong contrast
- Slight tilt on lane switch with smooth transition
- **Stylized smoke trail** continuously emitted while the car moves
- **Lane-switch smoke burst** — stylized smoke effect triggers on each lane change
### ✨ VFX & Particle Systems
- All particle systems tuned with appropriate emission limits, lifetime, and duration to avoid overdraw
- Proper **Stop Action** set on the lane-switch smoke trail effect for clean cleanup
- Shaders used: **URP Lit, URP Unlit, custom Toon Unlit (Shader Graph), URP Unlit Particle**
---
 
## ⚙️ Optimization Decisions
 
| Area | Decision | Reason |
|---|---|---|
| **Texture Atlasing** | Combined environment prop textures into a single atlas | Fewer texture swaps, reduced draw call overhead |
| **Material Keyword Matching** | Matched keywords across materials | Maximizes SRP Batch grouping by keeping shader variants compatible |
| **Sorting Priority** | Set proper renderer sorting priorities | Minimizes SRP Batch breaks from out-of-order rendering |
| **Shader Variant Reduction** | Minimized shader variants across all materials | Fewer GPU state changes, reduced overdraw risk |
| **Shader Selection** | URP Lit, URP Unlit, custom Toon Unlit, URP Unlit Particle | All URP/mobile-friendly; no unnecessary lighting overhead |
| **Local Adaptive Probe Volume** | Used local APV for GI | Accurate indirect lighting at low runtime cost |
| **Particle Overdraw Control** | Capped emission rate, lifetime, duration on all particle systems | Transparent overdraw is a primary mobile GPU bottleneck |
| **Stop Action on Smoke Trail** | Proper Stop Action configured on lane-switch effect | Ensures clean destruction, prevents lingering overdraw |
 
**Target achieved: Stable 60 FPS on low-end/mobile devices.**
 
---
 
## 🛠️ Assets & Tools Used
 
- **Unity URP** (Universal Render Pipeline)
- **Shader Graph** — custom Toon Unlit shader
- **Unity Particle System** — motion trail and lane-switch smoke
- **Post Processing (URP Volume)**
- **Adaptive Probe Volumes (APV)**
---
 
## 🎬 Demo Video
 
> See attached/linked gameplay video showcasing lighting, colors, VFX, and overall game feel.
 
