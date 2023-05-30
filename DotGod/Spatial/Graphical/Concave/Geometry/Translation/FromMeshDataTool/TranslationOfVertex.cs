using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Translation.FromMeshDataTool;

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