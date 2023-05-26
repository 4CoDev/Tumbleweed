using Godot;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Translation.FromMeshDataTool.ToGodot;

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