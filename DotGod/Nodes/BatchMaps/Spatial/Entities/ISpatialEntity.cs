using DotGod.Geometry.Spatial.Graphical.Meshes;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Godot;
using Tumbleweed.Nullables;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

public interface ISpatialEntity
{
	INullable<Node> Node { get; }
	
	IMesh Mesh { get; }
	
	ISpace Occupation { get; }
}