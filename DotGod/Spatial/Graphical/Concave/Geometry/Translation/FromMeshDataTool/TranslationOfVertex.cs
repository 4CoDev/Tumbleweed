using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;

using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;
using Any = Tumbleweed.Number.Real.Any;
using One = DotGod.Point.Spatial.From.Vector.One;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Translation.FromMeshDataTool;

public sealed class TranslationOfVertex : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public TranslationOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public TranslationOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> mesh, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	) : base
	(
		new One(
			new ToGodot.TranslationOfVertex(mesh, vertex))
	)
	{
	}
}