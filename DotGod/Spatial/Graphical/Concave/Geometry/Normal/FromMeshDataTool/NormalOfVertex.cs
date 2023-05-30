using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal.FromMeshDataTool;

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