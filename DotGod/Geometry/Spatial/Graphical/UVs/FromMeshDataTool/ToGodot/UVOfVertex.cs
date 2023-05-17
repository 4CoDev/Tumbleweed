using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.UVs.FromMeshDataTool.ToGodot;

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
		new ResultOfFunction<Vector2>(
			() => tool.Value.GetVertexUV(vertex.Value))
	)
	{
	}
}