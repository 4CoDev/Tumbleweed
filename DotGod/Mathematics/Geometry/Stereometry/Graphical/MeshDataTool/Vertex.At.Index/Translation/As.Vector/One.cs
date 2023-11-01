using Godot;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Translation.As.Vector;

public sealed class One : Envelope<Vector3>
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