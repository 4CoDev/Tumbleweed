using DotGod.Numerics.Decimals.Spatials.FromGodot;
using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Normals.FromMeshDataTool;

public sealed class NormalOfVertex : SpatialEnvelope<IFractional>
{
	public NormalOfVertex
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
	
	public NormalOfVertex
	(
		IScalar<MeshDataTool> mesh,
		IScalar<Int32> vertex
	) : base
	(
		new SpatialFromVector3(
			new ToGodot.NormalOfVertex(mesh, vertex))
	)
	{
	}
}