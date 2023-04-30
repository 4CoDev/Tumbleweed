using DotGod.Numerics.Decimals.Spatials.FromGodot;
using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Translations.FromMeshDataTool;

public sealed class TranslationOfVertex : SpatialEnvelope<IReal>
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
		new SpatialFromVector3(
			new ToGodot.TranslationOfVertex(mesh, vertex))
	)
	{
	}
}