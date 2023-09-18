using Nullable = Tumbleweed.Scalar.Nullable;
using Godot = Godot;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity;

public interface Any
{
	Nullable::Any<Godot::Node> Node { get; }
	
	Geometry.Spatial.Graphical.Mesh.Any Mesh { get; }
	
	Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any Aabb { get; }
}