using Godot;

namespace tenshinojinsei;

[GlobalClass]
public partial class FollowBatchComponent : BatchComponent {
    [Export] public Node2D? Target;
    [Export] public float Speed = 4f;

    public override void _Ready() {
        base._Ready();
        SetPhysicsProcess(Target is not null);
    }

    public override void _PhysicsProcess(double pDelta) {
        BatchFactory batchFactory = GetBatchFactory();

        for (int i = 0; i < batchFactory.Multimesh.InstanceCount; ++i) {
            float rand = (float)GD.RandRange(1.0d, Speed / 2.0d);
            Transform2D currentTransform = batchFactory.Multimesh.GetInstanceTransform2D(i);
            currentTransform.Origin =
                ToGlobal(currentTransform.Origin).MoveToward(Target!.GlobalTransform.Origin, Speed - rand );
            currentTransform.Origin = ToLocal(currentTransform.Origin);
            batchFactory.Multimesh.SetInstanceTransform2D(i, currentTransform);
        }
    }
}