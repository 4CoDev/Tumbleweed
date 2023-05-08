using Godot;
using DotGod.Numerics.Decimals.Spatials.FromGodot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Translations.FromMeshDataTool.ToGodot;

public sealed class TranslationOfVertex : ScalarEnvelope<Vector3>
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
		new ResultOfFunction<Vector3>(
			() => mesh.Value.GetVertex(vertex.Value))
	)
	{
	}
}