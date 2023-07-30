using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Number.Natural;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal.FromMeshDataTool.ToGodot;

public sealed class NormalOfVertex : Envelope<Vector3>
{
	public NormalOfVertex
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

	public NormalOfVertex
	(
		Any<MeshDataTool> mesh,
		Any<Int32> vertex
	) : base
	(
		new Actual<Vector3>(
			() => mesh.Value.GetVertexNormal(vertex.Value))
	)
	{
	}
}