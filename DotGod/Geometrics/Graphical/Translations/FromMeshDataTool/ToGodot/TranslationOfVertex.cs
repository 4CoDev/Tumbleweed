using Godot;
using DotGod.Numerics.Decimals.Spatials.FromGodot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Translations.FromMeshDataTool.ToGodot;

public sealed class TranslationOfVertex : ScalarEnvelope<Vector3>
{
	public TranslationOfVertex
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
	
	public TranslationOfVertex
	(
		IScalar<MeshDataTool> mesh,
		IScalar<Int32> vertex
	) : base
	(
		new ValueOfFunction<Vector3>(
			() => mesh.Value.GetVertex(vertex.Value))
	)
	{
	}
}