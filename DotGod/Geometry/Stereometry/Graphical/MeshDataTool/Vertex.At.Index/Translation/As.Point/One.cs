using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Translation.As.Point;

public sealed class One : Envelope<Any>
{
	public One
	(
		Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> tool,
		Tumbleweed.Mathematics.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public One
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> mesh, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	) : base
	(
		new DotGod.Point.Spatial.From.Vector.One(
			new Vector.One(mesh, vertex))
	)
	{
	}
}