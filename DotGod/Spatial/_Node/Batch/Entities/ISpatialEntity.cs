using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Scalar.Nullable;

namespace DotGod.Spatial._Node.Batch.Entities;

public interface ISpatialEntity
{
	Any<Godot.Node> Node { get; }
	
	IMesh Mesh { get; }
	
	ISpace Occupation { get; }
}