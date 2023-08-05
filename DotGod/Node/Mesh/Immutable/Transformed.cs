using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Mesh.Immutable;

public sealed class Transformed : MeshEnvelope
{
	public Transformed(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
	)
	{
	}
	
	public Transformed(Any<MeshInstance3D> node) : base
	(
		new TransformedMesh(
			new Untransformed.Tumbleweed(node),
			node.Value.Transform)
	)
	{
	}
}