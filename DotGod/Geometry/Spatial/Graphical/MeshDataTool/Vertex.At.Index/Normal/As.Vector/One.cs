using Godot;
using Tumbleweed.Number.Natural;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Geometry.Spatial.Graphical.MeshDataTool.Vertex.At.Index.Normal.As.Vector;

public sealed class One : Envelope<Vector3>
{
	public One
	(
		Any<Godot.MeshDataTool> tool,
		Any vertex
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
			() => mesh.Value.GetVertexNormal(vertex.Value))
	)
	{
	}
}