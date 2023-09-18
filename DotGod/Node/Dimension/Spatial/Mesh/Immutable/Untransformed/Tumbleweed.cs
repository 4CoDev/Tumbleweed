using DotGod.Geometry.Spatial.Graphical.Mesh;
using DotGod.Geometry.Spatial.Graphical.Mesh.From.Godot;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Dimension.Spatial.Mesh.Immutable.Untransformed;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
	)
	{
	}

	public Tumbleweed(Any<MeshInstance3D> node) : base
	(
		new One(
			new Godot.Mesh(node))
	)
	{
	}
}