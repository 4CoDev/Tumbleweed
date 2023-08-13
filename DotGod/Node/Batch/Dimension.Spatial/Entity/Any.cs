using Nullable = Tumbleweed.Scalar.Nullable;
using Godot = Godot;
using GraphicalGeometry = DotGod.Geometry.Spatial.Concave.Graphical.Mesh;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity;

public interface Any
{
	Nullable::Any<Godot::Node> Node { get; }
	
	GraphicalGeometry::Any Mesh { get; }
	
	Spatial.Space.Any Occupation { get; }
}