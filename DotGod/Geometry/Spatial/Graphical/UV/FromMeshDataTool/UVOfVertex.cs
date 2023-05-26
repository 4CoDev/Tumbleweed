using DotGod.Vector.Planar.Point;
using Godot;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Planar;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.UV.FromMeshDataTool;

public sealed class UVOfVertex : PointEnvelope<IReal>
{
	public UVOfVertex
	(
		IScalar<MeshDataTool> tool,
		INatural vertex
	) : this
	(
		tool,
		new Int32FromNatural(vertex)
	)
	{
	}
	
	public UVOfVertex
	(
		IScalar<MeshDataTool> tool,
		IScalar<Int32> vertex
	) : base
	(
		new PointFromVector2(
			new ToGodot.UVOfVertex(tool, vertex))
	)
	{
	}
}