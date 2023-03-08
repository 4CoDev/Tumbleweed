using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Existence;

namespace TumbleGD.Nodes.Baking.Spatial.Entities;

public interface IBakingEntity
{
	IExistence<Node> Node { get; }
	
	IEnumerable<ISurface> Mesh { get; }
}