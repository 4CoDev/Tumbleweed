using DotGod.Numerics.Decimals.Spatials.FromGodot;
using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Normals.FromMeshDataTool;

public sealed class NormalOfVertex : SpatialEnvelope<IReal>
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
		new SpatialFromVector3(
			new ToGodot.NormalOfVertex(mesh, vertex))
	)
	{
	}
}