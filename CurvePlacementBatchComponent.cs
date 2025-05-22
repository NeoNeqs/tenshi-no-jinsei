using Godot;

namespace tenshinojinsei;

[Tool, GlobalClass]
public partial class CurvePlacementBatchComponent : BatchComponent {
    [Export] public float Radius;
    [Export] public Curve? Curve;

    public override void _Ready() {
        base._Ready();

        BatchFactory batchFactory = GetBatchFactory();
        batchFactory.CountChanged += Update;
        Update();
    }

    private void Update() {
        if (Curve is null) {
            return;
        }
        
        BatchFactory batchFactory = GetBatchFactory();
        for (int i = 0; i < batchFactory.Multimesh.InstanceCount; ++i) {
            float angle = Curve.Sample(i / (float)batchFactory.Multimesh.InstanceCount);
            Vector2 newPosition = Radius * new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
            batchFactory.Multimesh.SetInstanceTransform2D(i, new Transform2D(0, newPosition));
        }
    }
}