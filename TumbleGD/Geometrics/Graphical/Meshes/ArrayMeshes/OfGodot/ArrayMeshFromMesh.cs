using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot;

public sealed class ArrayMeshFromMesh : ScalarEnvelope<ArrayMesh>
{
	public ArrayMeshFromMesh(IScalar<Mesh> mesh) : base
	(
		new ObjectAsType<ArrayMesh>(mesh)
	)
	{
	}
}