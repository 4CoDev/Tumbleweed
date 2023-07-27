using DotGod.Planar.Vector.Point;
using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;

using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Planar;
using Tumbleweed.Scalar;
using Any = Tumbleweed.Number.Real.Any;

namespace DotGod.Spatial.Graphical.Concave.Geometry.UV.FromMeshDataTool;

public sealed class UVOfVertex : Tumbleweed.Point.Planar.Envelope<Any>
{
	public UVOfVertex
	(Tumbleweed.Scalar.Any<MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new One(vertex)
	)
	{
	}
	
	public UVOfVertex
	(Tumbleweed.Scalar.Any<MeshDataTool> tool, Tumbleweed.Scalar.Any<Int32> vertex
	) : base
	(
		new PointFromVector2(
			new ToGodot.UVOfVertex(tool, vertex))
	)
	{
	}
}