using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;

using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;
using Any = Tumbleweed.Number.Real.Any;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Translation.FromMeshDataTool;

public sealed class TranslationOfVertex : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public TranslationOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new One(vertex)
	)
	{
	}
	
	public TranslationOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> mesh, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	) : base
	(
		new PointFromVector3(
			new ToGodot.TranslationOfVertex(mesh, vertex))
	)
	{
	}
}