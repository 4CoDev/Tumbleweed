using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Nullability;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities;

public interface ISpatialEntity
{
	INullable<Node> Node { get; }
	
	IEnumerable<ISurface> Mesh { get; }
}