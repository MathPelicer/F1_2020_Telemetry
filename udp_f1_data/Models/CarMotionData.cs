﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udp_f1_data.Models
{
    public struct CarMotionData
    {
        float m_worldPositionX;           // World space X position
        float m_worldPositionY;           // World space Y position
        float m_worldPositionZ;           // World space Z position
        float m_worldVelocityX;           // Velocity in world space X
        float m_worldVelocityY;           // Velocity in world space Y
        float m_worldVelocityZ;           // Velocity in world space Z
        int m_worldForwardDirX;         // World space forward X direction (normalised)
        int m_worldForwardDirY;         // World space forward Y direction (normalised)
        int m_worldForwardDirZ;         // World space forward Z direction (normalised)
        int m_worldRightDirX;           // World space right X direction (normalised)
        int m_worldRightDirY;           // World space right Y direction (normalised)
        int m_worldRightDirZ;           // World space right Z direction (normalised)
        float m_gForceLateral;            // Lateral G-Force component
        float m_gForceLongitudinal;       // Longitudinal G-Force component
        float m_gForceVertical;           // Vertical G-Force component
        float m_yaw;                      // Yaw angle in radians
        float m_pitch;                    // Pitch angle in radians
        float m_roll;                     // Roll angle in radians   
    }
}
