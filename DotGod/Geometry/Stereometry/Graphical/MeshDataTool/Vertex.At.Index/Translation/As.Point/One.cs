using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Translation.As.Point;

public sealed class One : Envelope<Tumbleweed.Number.Real.Any>
{
	public One
	(
		Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
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