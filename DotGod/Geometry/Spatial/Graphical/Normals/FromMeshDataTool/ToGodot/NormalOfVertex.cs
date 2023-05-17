using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Normals.FromMeshDataTool.ToGodot;

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
		new ResultOfFunction<Vector3>(
			() => mesh.Value.GetVertexNormal(vertex.Value))
	)
	{
	}
}