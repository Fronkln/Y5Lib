using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public enum JobPhase : uint
    {
        SystemAboveNormal,
        SystemNormal,
        BeforeCameraNormal,
        BeforeCameraBelowNormal,
        Camera,
        SystemCullingSetup,
        AfterCameraHigh,
        ActionPathEdgeUpdate,
        AfterCameraNormal,
        AfterCameraBelowNormal,
        AfterCameraLow,
        StaticCollisionUpdate,
        StaticCollisionDynamicsUpdate,
        BeforePhysicsHigh,
        BeforePhysicsBelowNormal,
        BeforePhysicsLow,
        PhysicsSetup,
        Physics,
        AfterPhysicsHigh,
        AfterPhysicsAboveNormal
    }
}
