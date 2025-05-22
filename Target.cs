using Godot;
using System;

public partial class Target : Node2D {
    public override void _PhysicsProcess(double delta) {
        GlobalPosition = GetGlobalMousePosition();
    }
}
