using DotGod.Vector.Spatial.Point;
using Godot;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Translation.FromMeshDataTool;

public sealed class TranslationOfVertex : PointEnvelope<IReal>
{
	public TranslationOfVertex
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
	
	public TranslationOfVertex
	(
		IScalar<MeshDataTool> mesh,
		IScalar<Int32> vertex
	) : base
	(
		new PointFromVector3(
			new ToGodot.TranslationOfVertex(mesh, vertex))
	)
	{
	}
}