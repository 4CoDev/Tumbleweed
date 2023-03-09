using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Existence;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities;

public interface IBakingEntity
{
	IExistence<Node> Node { get; }
	
	IEnumerable<ISurface> Mesh { get; }
}