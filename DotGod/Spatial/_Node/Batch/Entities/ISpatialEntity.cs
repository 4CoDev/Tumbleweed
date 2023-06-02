using DotGod.Spatial._Node.Batch.Spaces;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Batch.Entities;

public interface ISpatialEntity
{
	INullable<Node> Node { get; }
	
	IMesh Mesh { get; }
	
	ISpace Occupation { get; }
}