using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using DotGod.Geometry.Spatial.Concave.Graphical.Mesh.From.Godot;
using DotGod.Node.Mesh.Immutable.Untransformed.Godot;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Mesh.Immutable.Untransformed;

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