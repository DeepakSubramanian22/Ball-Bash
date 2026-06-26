# 🏰 Ball Bash

> **Defend the Tower. Bash the Foot!**

Ball Bash is a fast-paced 3D wave-based tower defense game built with **Unity 6** and **C#**. You control a heroic ball standing on top of a tower while enemy footballs attempt to push you off. Collect power-ups, survive increasingly difficult waves, and defend the tower for as long as possible.

---

## 🎮 Gameplay

- Defend the tower against incoming enemy footballs.
- Knock enemies off the tower before they push you down.
- Collect Power-Ups to gain increased knockback strength.
- Power-Ups last for **7 seconds**, implemented using Unity Coroutines.
- Each new wave doubles the number of enemies, making the game progressively more challenging.
- Stay on the tower and survive as many waves as possible.

---

## ✨ Features

- 🏰 Wave-based survival gameplay
- ⚽ Physics-based enemy interactions
- 💥 Knockback combat using Unity Rigidbody physics
- ⭐ Temporary Power-Up system (7-second duration)
- 🔁 Coroutine-based Power-Up timer
- 📈 Progressive difficulty with increasing enemy count
- 🎵 Background music and sound effects
- 🎥 Third-person rotating camera
- 🎮 Lobby, Gameplay, and Game Over scenes
- 🖥️ Clean and responsive UI

---

## 🎮 Controls

| Action | Key |
|--------|-----|
| Move Forward | **W** |
| Move Backward | **S** |
| Rotate Camera Left | **A** |
| Rotate Camera Right | **D** |

The camera automatically rotates around the tower when pressing **A** and **D**, allowing the player to monitor enemies approaching from every direction.

---

## ⭐ Power-Up System

Collect the glowing Power-Up to temporarily increase your knockback force.

- Duration: **7 Seconds**
- Implemented using **Coroutine**
- Enables powerful attacks that launch enemies off the tower

---

## 🌊 Wave System

The game becomes increasingly difficult with each wave.

| Wave | Enemy Count |
|------|-------------|
| 1 | 1 Enemy |
| 2 | 2 Enemies |
| 3 | 4 Enemies |
| 4 | 8 Enemies |
| ... | Continues to Double |

---

## 🛠️ Technologies Used

- Unity 6
- C#
- Unity Physics (Rigidbodies & Collisions)
- Coroutines
- Scene Management
- Audio Source
- Unity UI

---

## 📂 Project Structure

```
Assets
│
├── Scenes
│   ├── Lobby
│   ├── GameScene
│   └── GameOver
│
├── Scripts
│   ├── PlayerControl
│   ├── Enemy
│   ├── SpawnManager
│   ├── RotateCamera
│   ├── AudioManager
│   └── LobbyController
│
├── Prefabs
├── Audio
├── Sprites
└── Materials
```

---

## 🎯 Objective

Your mission is simple:

- Defend the tower.
- Collect Power-Ups.
- Knock enemy footballs off the platform.
- Survive increasingly difficult waves.

⚠️ If the player is pushed off the tower, the game is over.



## 📚 Unity Concepts Practiced

- Object-Oriented Programming (OOP)
- Rigidbody Physics
- Collision Detection
- Trigger Events
- Coroutines
- Wave Spawning
- Scene Management
- Audio Management
- UI Design
- Camera Rotation

---

## 🚀 Future Improvements

- Score System
- High Score Leaderboard
- Multiple Power-Ups
- Enemy Variations
- Boss Waves
- Difficulty Modes
- Particle Effects
- Mobile Support

---

## 👨‍💻 Developer

**Deepak Subramanian

Unity Game Developer

---

⭐ **If you enjoyed this project, consider giving it a Star!**
