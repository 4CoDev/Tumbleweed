using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Mesh.Immutable.Untransformed.Godot;

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
		new ArrayMeshFromMesh(
			new Mesh(node))
	)
	{
	}
}