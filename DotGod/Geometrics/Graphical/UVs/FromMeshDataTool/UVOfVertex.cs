using DotGod.Numerics.Decimals.Planars.FromGodot;
using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.UVs.FromMeshDataTool;

public sealed class UVOfVertex : PlanarEnvelope<IFractional>
{
	public UVOfVertex
	(
		IScalar<MeshDataTool> tool,
		INaturalInteger vertex
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