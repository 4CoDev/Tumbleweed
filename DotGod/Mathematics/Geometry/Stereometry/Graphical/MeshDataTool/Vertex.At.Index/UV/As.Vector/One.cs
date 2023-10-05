using Godot;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.UV.As.Vector;

public sealed class One : Envelope<Vector2>
{
	public One
	(
		Any<Godot.MeshDataTool> tool,
		Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public One
	(
		Any<Godot.MeshDataTool> tool,
		Any<Int32> vertex
	) : base
	(
		new Actual<Vector2>(
			() => tool.Value.GetVertexUV(vertex.Value))
	)
	{
	}
}