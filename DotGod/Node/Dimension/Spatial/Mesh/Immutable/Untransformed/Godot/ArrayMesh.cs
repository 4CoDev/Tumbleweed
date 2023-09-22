using DotGod.Geometry.Stereometry.Graphical.ArrayMesh.From.Mesh;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Dimension.Spatial.Mesh.Immutable.Untransformed.Godot;

public sealed class ArrayMesh : Envelope<global::Godot.ArrayMesh>
{
	public ArrayMesh(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
	)
	{
	}
	
	public ArrayMesh(Any<MeshInstance3D> node) : base
	(
		new One(
			new Mesh(node))
	)
	{
	}
}