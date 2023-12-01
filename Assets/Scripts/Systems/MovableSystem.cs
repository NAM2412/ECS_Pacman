using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

public partial class MovableSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float dt = Time.DeltaTime;
     
        Entities.ForEach((ref PhysicsVelocity physVel, in Movable mov) => 
        {
            var step = mov.direction * mov.speed;
            physVel.Linear = step;
        }).Schedule();
    }
}
