using DotGod.Numbers.Real.Planars.FromGodot;
using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.UVs.FromMeshDataTool;

public sealed class UVOfVertex : PlanarEnvelope<IReal>
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
		new PlanarFromVector2(
			new ToGodot.UVOfVertex(tool, vertex))
	)
	{
	}
}