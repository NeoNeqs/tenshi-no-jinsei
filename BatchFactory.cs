using Godot;

namespace tenshinojinsei;

[Tool, GlobalClass]
public partial class BatchFactory : MultiMeshInstance2D {
    
    [Signal]
    public delegate void CountChangedEventHandler();
    
    [Export]
    public int Count {
        set  {
            if (Multimesh is not null) {
                Multimesh.InstanceCount = value;
            }
            EmitSignalCountChanged();
        }
        get => Multimesh?.InstanceCount ?? 0;
    }

#if DEBUG
    public override string[] _GetConfigurationWarnings() {
        if (Multimesh is null) {
            return [$"{nameof(BatchFactory)} needs a {nameof(MultiMesh)} to function properly."];
        }

        return [];
    }
#endif
}