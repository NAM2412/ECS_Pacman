using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public partial class PlayerSystem : SystemBase
{
    protected override void OnUpdate()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        Entities.
            WithAll<Players>()
            .ForEach((ref Movable mov) =>
        {
            mov.direction = new float3(x, 0, y);
        }).Schedule();
    }
}
