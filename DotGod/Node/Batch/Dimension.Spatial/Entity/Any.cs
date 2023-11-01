using Nullable = Tumbleweed.Property.Nullable;
using Godot = Godot;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity;

public interface Any
{
	Nullable::Any<Godot::Node> Node { get; }
	
	Mathematics.Geometry.Stereometry.Graphical.Mesh.Any Mesh { get; }
	
	Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb { get; }
}