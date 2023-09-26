using Tumbleweed.Mathematics.Geometry.Planimetry.Point;
using Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.UV.As.Point;

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
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> tool, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	) : base
	(
		new DotGod.Point.Planar.From.Vector.One(
			new Vector.One(tool, vertex))
	)
	{
	}
}