using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Existence;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities;

public interface ISpatialEntity
{
	IExistence<Node> Node { get; }
	
	IEnumerable<ISurface> Mesh { get; }
}