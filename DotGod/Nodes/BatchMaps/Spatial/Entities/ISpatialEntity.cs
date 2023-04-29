using DotGod.Geometrics.Graphical.Meshes;
using DotGod.Nodes.BatchMaps.Spatial.Occupation;
using Godot;
using Tumbleweed.Nullability;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

public interface ISpatialEntity
{
	INullable<Node> Node { get; }
	
	IMesh Mesh { get; }
	
	IOccupiedSpace Occupation { get; }
}