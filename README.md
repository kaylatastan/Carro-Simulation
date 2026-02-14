# Carro-Simulation

**Carro-Simulation** is a high-fidelity vehicle dynamics framework developed in Unity, focusing on the rigorous mathematical modeling of automotive physics. Rather than relying on simplified arcade physics, this project implements a complete drivetrain and suspension architecture to achieve a professional-grade simulation experience.

---

<img width="1919" height="1079" alt="Screenshot 2025-12-23 232740" src="https://github.com/user-attachments/assets/27288ae1-35f6-494a-8eb4-d31ec7e5e20e" />



## Technical Architecture & Physics

The simulation is built upon a modular physics-based architecture where every component of the vehicle interacts realistically with the environment and internal systems.

### 1. Powertrain and Transmission
* **Torque-Based Engine Model:** Simulation of realistic engine torque curves, power bands, and rotational inertia.
* **Advanced Gearbox Logic:** Detailed transmission modeling featuring customizable gear ratios, final drive settings, and shifting delays.
* **Differential Dynamics:** Implementation of various differential types to manage power distribution across the drive wheels effectively.

### 2. Suspension and Handling
* **Advanced Suspension Geometry:** Individual spring and damper rates with support for complex suspension kinematics (including anti-roll bars and bump stops).
* **Steering Geometry:** Accurate steering implementations incorporating Ackermann geometry to ensure realistic cornering behavior and tire alignment.
* **Subframe and Mass Distribution:** Dynamic center of mass calculations that respond to weight transfer during acceleration, braking, and cornering.

### 3. Tire Dynamics and Friction
* **Friction Models:** Sophisticated tire-to-surface interaction models that account for longitudinal and lateral slip, camber thrust, and varying surface friction coefficients ($\mu$).
* **Force Feedback Ready:** Physics calculations are processed at a high frequency to support detailed telemetry and potential force feedback integration.

---

## Visuals & Gameplay

<p align="center">
<img width="1919" height="1079" alt="Screenshot 2025-12-23 233425" src="https://github.com/user-attachments/assets/9a119b31-aa8d-46a0-8632-132a6118f9c2" />
</p>

*The simulation provides a balance between high-end technical accuracy and a visually immersive driving environment.*

---

## Technical Implementation Notes

The project follows a highly modular approach, allowing for:
* **Component-Based Design:** Easily swap engine, transmission, or tire models to test different vehicle configurations.
* **Performance Optimization:** Efficient physics calculations optimized for high-frequency updates without sacrificing frame rate.
* **Data-Driven Configuration:** Vehicle parameters are exposed for fine-tuning via external data structures, mimicking real-world automotive tuning.

---



