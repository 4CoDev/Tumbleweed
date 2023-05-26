using DotGod._Node.BatchMap.Spatial.Spaces;
using DotGod.Geometry.Spatial.Graphical._Mesh;
using Godot;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Entities;

public interface ISpatialEntity
{
	INullable<Node> Node { get; }
	
	IMesh Mesh { get; }
	
	ISpace Occupation { get; }
}