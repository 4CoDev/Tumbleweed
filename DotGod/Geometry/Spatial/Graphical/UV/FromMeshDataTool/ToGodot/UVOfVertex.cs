using Godot;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.UV.FromMeshDataTool.ToGodot;

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