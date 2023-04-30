using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.UVs.FromMeshDataTool.ToGodot;

public sealed class UVOfVertex : ScalarEnvelope<Vector2>
{
	public UVOfVertex
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
	
	public UVOfVertex
	(
		IScalar<MeshDataTool> tool,
		IScalar<Int32> vertex
	) : base
	(
		new ValueOfFunction<Vector2>(
			() => tool.Value.GetVertexUV(vertex.Value))
	)
	{
	}
}