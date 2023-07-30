using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;

public sealed class ArrayMeshFromMesh : Envelope<Godot.ArrayMesh>
{
	public ArrayMeshFromMesh(Any<Godot.Mesh> mesh) : base
	(
		new Tumbleweed.Object.Unpacked<Godot.ArrayMesh>(mesh)
	)
	{
	}
}