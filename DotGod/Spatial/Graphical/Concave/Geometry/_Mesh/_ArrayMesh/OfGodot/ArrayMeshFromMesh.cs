using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;

public sealed class ArrayMeshFromMesh : ScalarEnvelope<Godot.ArrayMesh>
{
	public ArrayMeshFromMesh(IScalar<Godot.Mesh> mesh) : base
	(
		new ObjectAsType<Godot.ArrayMesh>(mesh)
	)
	{
	}
}