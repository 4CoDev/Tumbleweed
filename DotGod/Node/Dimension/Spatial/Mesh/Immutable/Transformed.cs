using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using DotGod.Geometry.Spatial.Concave.Graphical.Mesh.Transformed;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Dimension.Spatial.Mesh.Immutable;

public sealed class Transformed : Envelope
{
	public Transformed(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
	)
	{
	}
	
	public Transformed(Any<MeshInstance3D> node) : base
	(
		new One(
			new Untransformed.Tumbleweed(node),
			node.Value.Transform)
	)
	{
	}
}