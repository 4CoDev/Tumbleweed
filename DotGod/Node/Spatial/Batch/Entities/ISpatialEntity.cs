using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using DotGod.Node.Spatial.Batch.Space;
using Tumbleweed.Scalar.Nullable;

namespace DotGod.Node.Spatial.Batch.Entities;

public interface ISpatialEntity
{
	Any<Godot.Node> Node { get; }
	
	Geometry.Spatial.Concave.Graphical.Mesh.Any Mesh { get; }
	
	ISpace Occupation { get; }
}