using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;
using Tumbleweed.Nullability;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities;

public interface ISpatialEntity
{
	INullable<Node> Node { get; }
	
	IMesh Mesh { get; }
	
	IOccupiedSpace Occupation { get; }
}