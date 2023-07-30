using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;

using Tumbleweed.Number.Natural;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Spatial.Graphical.Concave.Geometry.UV.FromMeshDataTool.ToGodot;

public sealed class UVOfVertex : Envelope<Vector2>
{
	public UVOfVertex
	(
		Any<MeshDataTool> tool,
		Any vertex
	) : this
	(
		tool,
		new One(vertex)
	)
	{
	}
	
	public UVOfVertex
	(
		Any<MeshDataTool> tool,
		Any<Int32> vertex
	) : base
	(
		new Actual<Vector2>(
			() => tool.Value.GetVertexUV(vertex.Value))
	)
	{
	}
}