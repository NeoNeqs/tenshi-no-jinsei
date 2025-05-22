extends Node2D

#@onready var multi_mesh_instance_2d: MultiMeshInstance2D = $Path2D/PathFollow2D/Node2D/MultiMeshInstance2D
#@onready var path_follow_2d: PathFollow2D = $Path2D/PathFollow2D
#@export var c: Curve
#
#func _ready() -> void:
	#const count := 20
	#multi_mesh_instance_2d.multimesh.instance_count = count
	#const r := 400
	#for i in count:
		#var angle := (i / float(count)) * TAU
		#var pos := r * Vector2(cos(angle), sin(angle))
		#multi_mesh_instance_2d.multimesh.set_instance_transform_2d(i, Transform2D(0, pos))
#
#func _physics_process(delta: float) -> void:
	#for i in multi_mesh_instance_2d.multimesh.instance_count:
		#var curr := multi_mesh_instance_2d.multimesh.get_instance_transform_2d(i)
		#curr = curr.interpolate_with(global_transform, 0.01)
		#multi_mesh_instance_2d.multimesh.set_instance_transform_2d(i, curr)
#
	#path_follow_2d.progress_ratio += 0.5 * delta
