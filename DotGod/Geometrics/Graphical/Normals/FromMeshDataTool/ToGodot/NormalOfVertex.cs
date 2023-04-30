using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Normals.FromMeshDataTool.ToGodot;

public sealed class NormalOfVertex : ScalarEnvelope<Vector3>
{
	public NormalOfVertex
	(
		IScalar<MeshDataTool> tool,
		INatural vertex
	) : this
	(
		tool,
		new Int32FromNatural(vertex)
	)
	{
	}

	public NormalOfVertex
	(
		IScalar<MeshDataTool> mesh,
		IScalar<Int32> vertex
	) : base
	(
		new ValueOfFunction<Vector3>(
			() => mesh.Value.GetVertexNormal(vertex.Value))
	)
	{
	}
}