using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using GodotArray = Godot.Collections.Array;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.FromSurfaceTools.
	FromGodot;

public sealed class IndicesFromSurfaceTool : EnumerableEnvelope<Int32>
{
	public IndicesFromSurfaceTool(IScalar<SurfaceTool> tool) : base
	(
		new EnumerableOfFunction<Int32>(
			() => Function(tool))
	)
	{
	}

	private static IEnumerable<Int32> Function(IScalar<SurfaceTool> tool)
	{
		GodotArray surfaceAsArrays = tool.Value.CommitToArrays();
		const Int32 indexArrayType = (Int32) Mesh.ArrayType.Index;
		Int32[] indicesAsValues = surfaceAsArrays[indexArrayType].AsInt32Array();
		return indicesAsValues;
	}
}