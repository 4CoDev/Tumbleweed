using Tumbleweed.Point.Spatial.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;

namespace DotGod.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Normal.As.Point;

public sealed class One : Envelope<Any>
{
	public One
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> tool,
		Tumbleweed.Mathematics.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public One
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> mesh, Tumbleweed.Scalar
	.Immutable.Any<Int32> vertex
	) : base
	(
		new DotGod.Point.Spatial.From.Vector.One(
			new Vector.One(mesh, vertex))
	)
	{
	}
}