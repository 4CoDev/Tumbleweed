using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;
using Any = Tumbleweed.Number.Real.Any;
using One = DotGod.Point.Spatial.From.Vector.One;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal.FromMeshDataTool;

public sealed class NormalOfVertex : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public NormalOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public NormalOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> mesh, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	) : base
	(
		new One(
			new ToGodot.NormalOfVertex(mesh, vertex))
	)
	{
	}
}