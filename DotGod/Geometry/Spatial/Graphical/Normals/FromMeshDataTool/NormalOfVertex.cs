using DotGod.Vectors.Spatial.Points;
using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Normals.FromMeshDataTool;

public sealed class NormalOfVertex : PointEnvelope<IReal>
{
	public NormalOfVertex
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
	
	public NormalOfVertex
	(
		IScalar<MeshDataTool> mesh,
		IScalar<Int32> vertex
	) : base
	(
		new PointFromVector3(
			new ToGodot.NormalOfVertex(mesh, vertex))
	)
	{
	}
}