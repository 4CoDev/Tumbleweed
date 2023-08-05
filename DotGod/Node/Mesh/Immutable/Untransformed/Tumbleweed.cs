using DotGod.Node.Mesh.Immutable.Untransformed.Godot;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh.FromArrayMesh.FromGodot;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Mesh.Immutable.Untransformed;

public sealed class Tumbleweed : MeshEnvelope
{
	public Tumbleweed(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
	)
	{
	}

	public Tumbleweed(Any<MeshInstance3D> node) : base
	(
		new MeshFromGodot(
			new Godot.Mesh(node))
	)
	{
	}
}