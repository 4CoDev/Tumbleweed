using DotGod.Point.Planar;
using DotGod.Point.Planar.From;
using Godot;
using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;

using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Planar;
using Tumbleweed.Scalar;
using Any = Tumbleweed.Number.Real.Any;
using One = Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed.One;

namespace DotGod.Spatial.Graphical.Concave.Geometry.UV.FromMeshDataTool;

public sealed class UVOfVertex : Tumbleweed.Point.Planar.Envelope<Any>
{
	public UVOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new One(vertex)
	)
	{
	}
	
	public UVOfVertex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> tool, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	) : base
	(
		new DotGod.Point.Planar.From.Vector.One(
			new ToGodot.UVOfVertex(tool, vertex))
	)
	{
	}
}