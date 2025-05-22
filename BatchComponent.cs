using System.Diagnostics;
using Godot;

namespace tenshinojinsei;

[GlobalClass]
public abstract partial class BatchComponent : Node2D {
    
   
    
    public override void _Ready() {
        Debug.Assert(GetParent() is BatchFactory);
    }

    protected BatchFactory GetBatchFactory() {
        return GetParent<BatchFactory>();
    }
}
