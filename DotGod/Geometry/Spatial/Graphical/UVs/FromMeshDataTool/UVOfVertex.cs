using DotGod.Vectors.Planar.Points;
using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.UVs.FromMeshDataTool;

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