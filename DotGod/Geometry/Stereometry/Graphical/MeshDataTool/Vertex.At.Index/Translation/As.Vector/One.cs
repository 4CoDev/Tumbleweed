using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Translation.As.Vector;

public sealed class One : Envelope<Vector3>
{
	public One
	(
		Any<Godot.MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public One
	(
		Any<Godot.MeshDataTool> mesh,
		Any<Int32> vertex
	) : base
	(
		new Actual<Vector3>(
			() => mesh.Value.GetVertex(vertex.Value))
	)
	{
	}
}