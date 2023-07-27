using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;
using Any = Tumbleweed.Number.Real.Any;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal.FromMeshDataTool;

public sealed class NormalOfVertex : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public NormalOfVertex
	(Tumbleweed.Scalar.Any<MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new One(vertex)
	)
	{
	}
	
	public NormalOfVertex
	(Tumbleweed.Scalar.Any<MeshDataTool> mesh, Tumbleweed.Scalar.Any<Int32> vertex
	) : base
	(
		new PointFromVector3(
			new ToGodot.NormalOfVertex(mesh, vertex))
	)
	{
	}
}