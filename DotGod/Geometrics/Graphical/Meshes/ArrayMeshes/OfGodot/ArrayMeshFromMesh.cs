using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot;

public sealed class ArrayMeshFromMesh : ScalarEnvelope<ArrayMesh>
{
	public ArrayMeshFromMesh(IScalar<Mesh> mesh) : base
	(
		new ObjectAsType<ArrayMesh>(mesh)
	)
	{
	}
}